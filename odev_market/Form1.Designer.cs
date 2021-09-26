namespace odev_market
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_AlisverisDetay = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_ogrenci = new System.Windows.Forms.RadioButton();
            this.radioButton_yasli = new System.Windows.Forms.RadioButton();
            this.radioButton_hicbiri = new System.Windows.Forms.RadioButton();
            this.button_hesapla = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UrunAd = new System.Windows.Forms.TextBox();
            this.textBox_UrunFiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN FİYATI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-ALIŞVERİŞ DETAYLARI-";
            // 
            // listBox_AlisverisDetay
            // 
            this.listBox_AlisverisDetay.FormattingEnabled = true;
            this.listBox_AlisverisDetay.Location = new System.Drawing.Point(51, 183);
            this.listBox_AlisverisDetay.Name = "listBox_AlisverisDetay";
            this.listBox_AlisverisDetay.Size = new System.Drawing.Size(185, 147);
            this.listBox_AlisverisDetay.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "- İNDİRİM ORANI -";
            // 
            // radioButton_ogrenci
            // 
            this.radioButton_ogrenci.AutoSize = true;
            this.radioButton_ogrenci.Location = new System.Drawing.Point(321, 64);
            this.radioButton_ogrenci.Name = "radioButton_ogrenci";
            this.radioButton_ogrenci.Size = new System.Drawing.Size(94, 17);
            this.radioButton_ogrenci.TabIndex = 5;
            this.radioButton_ogrenci.TabStop = true;
            this.radioButton_ogrenci.Text = "ÖĞRENCİ  %5";
            this.radioButton_ogrenci.UseVisualStyleBackColor = true;
            // 
            // radioButton_yasli
            // 
            this.radioButton_yasli.AutoSize = true;
            this.radioButton_yasli.Location = new System.Drawing.Point(321, 87);
            this.radioButton_yasli.Name = "radioButton_yasli";
            this.radioButton_yasli.Size = new System.Drawing.Size(75, 17);
            this.radioButton_yasli.TabIndex = 6;
            this.radioButton_yasli.TabStop = true;
            this.radioButton_yasli.Text = "YAŞLI  %3";
            this.radioButton_yasli.UseVisualStyleBackColor = true;
            // 
            // radioButton_hicbiri
            // 
            this.radioButton_hicbiri.AutoSize = true;
            this.radioButton_hicbiri.Location = new System.Drawing.Point(321, 110);
            this.radioButton_hicbiri.Name = "radioButton_hicbiri";
            this.radioButton_hicbiri.Size = new System.Drawing.Size(142, 17);
            this.radioButton_hicbiri.TabIndex = 7;
            this.radioButton_hicbiri.TabStop = true;
            this.radioButton_hicbiri.Text = "HİÇBİRİ / İNDİRİM YOK";
            this.radioButton_hicbiri.UseVisualStyleBackColor = true;
            // 
            // button_hesapla
            // 
            this.button_hesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_hesapla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_hesapla.Location = new System.Drawing.Point(321, 171);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(133, 84);
            this.button_hesapla.TabIndex = 8;
            this.button_hesapla.Text = "HESAPLA";
            this.button_hesapla.UseVisualStyleBackColor = false;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // button_temizle
            // 
            this.button_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_temizle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_temizle.Location = new System.Drawing.Point(321, 284);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(133, 46);
            this.button_temizle.TabIndex = 9;
            this.button_temizle.Text = "TEMİZLE";
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_tutar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_tutar.Location = new System.Drawing.Point(213, 350);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(250, 20);
            this.textBox_tutar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOPLAM ÖDENECEK TUTAR :";
            // 
            // textBox_UrunAd
            // 
            this.textBox_UrunAd.Location = new System.Drawing.Point(136, 36);
            this.textBox_UrunAd.Name = "textBox_UrunAd";
            this.textBox_UrunAd.Size = new System.Drawing.Size(100, 20);
            this.textBox_UrunAd.TabIndex = 12;
            // 
            // textBox_UrunFiyat
            // 
            this.textBox_UrunFiyat.Location = new System.Drawing.Point(136, 77);
            this.textBox_UrunFiyat.Name = "textBox_UrunFiyat";
            this.textBox_UrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.textBox_UrunFiyat.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(524, 399);
            this.Controls.Add(this.textBox_UrunFiyat);
            this.Controls.Add(this.textBox_UrunAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_hesapla);
            this.Controls.Add(this.radioButton_hicbiri);
            this.Controls.Add(this.radioButton_yasli);
            this.Controls.Add(this.radioButton_ogrenci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_AlisverisDetay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MARKET TUTAR HESAPLAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_AlisverisDetay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_ogrenci;
        private System.Windows.Forms.RadioButton radioButton_yasli;
        private System.Windows.Forms.RadioButton radioButton_hicbiri;
        private System.Windows.Forms.Button button_hesapla;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_UrunAd;
        private System.Windows.Forms.TextBox textBox_UrunFiyat;
    }
}

