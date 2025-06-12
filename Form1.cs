using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipForm
{
    public partial class Form1: Form
    {
        List<Gonderi> gonderiler = new List<Gonderi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTur.Items.Add("Yurtiçi");
            cmbTur.Items.Add("Yurtdışı");

            cmbDurum.Items.Add("Yolda");
            cmbDurum.Items.Add("TeslimEdildi");

            lvGonderiler.Columns.Add("Takip No", 100);
            lvGonderiler.Columns.Add("Gönderen", 120);
            lvGonderiler.Columns.Add("Alıcı", 120);
            lvGonderiler.Columns.Add("Durum", 100);
            lvGonderiler.FullRowSelect = true;
            lvGonderiler.View = View.Details;
            lvGonderiler.GridLines = true;

            GonderileriYukle(); 
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string takipNo = txtTakipNo.Text;
            string gonderen = txtGonderen.Text;
            string alici = txtAlici.Text;
            string tur = cmbTur.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(takipNo) || string.IsNullOrEmpty(gonderen) ||
                string.IsNullOrEmpty(alici) || string.IsNullOrEmpty(tur))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            Gonderi gonderi;

            if (tur == "Yurtiçi")
                gonderi = new YurticiGonderi(takipNo, gonderen, alici);
            else
                gonderi = new YurtdisiGonderi(takipNo, gonderen, alici);

            gonderiler.Add(gonderi);
            ListViewItem item = new ListViewItem(gonderi.TakipNo);
            item.SubItems.Add(gonderi.Gonderen);
            item.SubItems.Add(gonderi.Alici);
            item.SubItems.Add(gonderi.Durum.ToString());

            lvGonderiler.Items.Add(item);

            // Temizle
            txtTakipNo.Clear();
            txtGonderen.Clear();
            txtAlici.Clear();
            cmbTur.SelectedIndex = -1;
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {

            if (lvGonderiler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir gönderi seçin.");
                return;
            }

            if (cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yeni bir durum seçin.");
                return;
            }

            // Seçilen gönderi
            int index = lvGonderiler.SelectedItems[0].Index;
            Gonderi gonderi = gonderiler[index];

            // Durumu güncelle
            string secilenDurum = cmbDurum.SelectedItem.ToString();
            if (secilenDurum == "Yolda")
                gonderi.DurumGuncelle(Durum.Yolda);
            else if (secilenDurum == "TeslimEdildi")
                gonderi.DurumGuncelle(Durum.TeslimEdildi);

            // ListView satırını güncelle
            lvGonderiler.Items[index].SubItems[3].Text = gonderi.Durum.ToString();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string takipNo = txtSorguTakipNo.Text.Trim();
            if (string.IsNullOrEmpty(takipNo))
            {
                MessageBox.Show("Lütfen takip numarası girin.");
                return;
            }

            var bulunan = gonderiler.FirstOrDefault(g => g.TakipNo == takipNo);

            if (bulunan != null)
            {
                MessageBox.Show($"Gönderi Bulundu:\n\nTakip No: {bulunan.TakipNo}\n" +
                                $"Gönderen: {bulunan.Gonderen}\n" +
                                $"Alıcı: {bulunan.Alici}\nDurum: {bulunan.Durum}");
            }
            else
            {
                MessageBox.Show("Bu takip numarasına ait gönderi bulunamadı.");
            }

            txtSorguTakipNo.Clear();
        }
        private void GonderileriKaydet()
        {
            using (StreamWriter sw = new StreamWriter("gonderiler.txt"))
            {
                foreach (var g in gonderiler)
                {
                    string tur = g is YurticiGonderi ? "Yurtiçi" : "Yurtdışı";
                    string satir = $"{g.TakipNo};{g.Gonderen};{g.Alici};{tur};{g.Durum}";
                    sw.WriteLine(satir);
                }
            }
        }
        private void GonderileriYukle()
        {
            if (!File.Exists("gonderiler.txt")) return;
            using (StreamReader sr = new StreamReader("gonderiler.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    if (parts.Length < 5) continue;
                    string takipNo = parts[0];
                    string gonderen = parts[1];
                    string alici = parts[2];
                    string tur = parts[3];
                    Durum durum = (Durum)Enum.Parse(typeof(Durum), parts[4]);
                    Gonderi gonderi;
                    if (tur == "Yurtiçi")
                        gonderi = new YurticiGonderi(takipNo, gonderen, alici);
                    else
                        gonderi = new YurtdisiGonderi(takipNo, gonderen, alici);
                    gonderi.DurumGuncelle(durum);
                    gonderiler.Add(gonderi);
                    ListViewItem item = new ListViewItem(gonderi.TakipNo);
                    item.SubItems.Add(gonderi.Gonderen);
                    item.SubItems.Add(gonderi.Alici);
                    item.SubItems.Add(gonderi.Durum.ToString());
                    lvGonderiler.Items.Add(item);
                }
            }
        }
    }
}


