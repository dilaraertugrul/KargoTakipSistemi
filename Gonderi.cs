using System;

namespace KargoTakipForm
{
    public enum Durum {
        Bekliyor,
        Yolda,
        TeslimEdildi
    }
    public interface ITakipEdilebilir {
        void DurumGuncelle(Durum yeniDurum);
        Durum GetDurum();
        string GetTakipNo();
    }

    public abstract class Gonderi : ITakipEdilebilir {
        public string TakipNo { get; set; }
        public string Gonderen { get; set; }
        public string Alici { get; set; }
        public Durum Durum { get; set; }

        public Gonderi(string takipNo, string gonderen, string alici) {
            TakipNo = takipNo;
            Gonderen = gonderen;
            Alici = alici;
            Durum = Durum.Bekliyor;
        }
        public void DurumGuncelle(Durum yeniDurum) {
            Durum = yeniDurum;
        }
        public Durum GetDurum() => Durum;

        public string GetTakipNo() => TakipNo;

        public override string ToString() {
            return $"Takip No: {TakipNo}, Gönderen: {Gonderen}, Alıcı: {Alici}, Durum: {Durum}";
        }
    }
    public class YurticiGonderi : Gonderi{
        public YurticiGonderi(string takipNo, string gonderen, string alici) : base(takipNo, gonderen, alici) { }
        }
    public class YurtdisiGonderi : Gonderi{
        public YurtdisiGonderi(string takipNo, string gonderen, string alici)
        : base(takipNo, gonderen, alici) { }
    }
}
