namespace KargoTakipForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakipNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGonderen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.durumlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvGonderiler = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSorguTakipNo = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takip No:";
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.Location = new System.Drawing.Point(173, 36);
            this.txtTakipNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.Size = new System.Drawing.Size(120, 27);
            this.txtTakipNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gönderen:";
            // 
            // txtGonderen
            // 
            this.txtGonderen.Location = new System.Drawing.Point(173, 80);
            this.txtGonderen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGonderen.Name = "txtGonderen";
            this.txtGonderen.Size = new System.Drawing.Size(120, 27);
            this.txtGonderen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alıcı:";
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(173, 137);
            this.txtAlici.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(120, 27);
            this.txtAlici.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tür:";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(173, 197);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(120, 28);
            this.cmbTur.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(173, 261);
            this.cmbDurum.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(120, 28);
            this.cmbDurum.TabIndex = 10;
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(622, 324);
            this.btnDurumGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(113, 29);
            this.btnDurumGuncelle.TabIndex = 11;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // durumlbl
            // 
            this.durumlbl.AutoSize = true;
            this.durumlbl.Location = new System.Drawing.Point(7, 20);
            this.durumlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durumlbl.Name = "durumlbl";
            this.durumlbl.Size = new System.Drawing.Size(57, 20);
            this.durumlbl.TabIndex = 12;
            this.durumlbl.Text = "Durum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(21, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 38);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(21, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 38);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(21, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 36);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(21, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 38);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.durumlbl);
            this.groupBox5.Location = new System.Drawing.Point(21, 249);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 40);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // lvGonderiler
            // 
            this.lvGonderiler.FullRowSelect = true;
            this.lvGonderiler.GridLines = true;
            this.lvGonderiler.HideSelection = false;
            this.lvGonderiler.Location = new System.Drawing.Point(352, 36);
            this.lvGonderiler.Name = "lvGonderiler";
            this.lvGonderiler.Size = new System.Drawing.Size(446, 253);
            this.lvGonderiler.TabIndex = 18;
            this.lvGonderiler.UseCompatibleStateImageBehavior = false;
            this.lvGonderiler.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Takip No İle Sorgula:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(21, 310);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(145, 41);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // txtSorguTakipNo
            // 
            this.txtSorguTakipNo.Location = new System.Drawing.Point(173, 321);
            this.txtSorguTakipNo.Name = "txtSorguTakipNo";
            this.txtSorguTakipNo.Size = new System.Drawing.Size(120, 27);
            this.txtSorguTakipNo.TabIndex = 20;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(352, 323);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(113, 30);
            this.btnSorgula.TabIndex = 21;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(810, 423);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtSorguTakipNo);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.lvGonderiler);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGonderen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTakipNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Kargo Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTakipNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGonderen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Label durumlbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvGonderiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSorguTakipNo;
        private System.Windows.Forms.Button btnSorgula;
    }
}

