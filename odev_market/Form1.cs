using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_market
{
    public partial class Form1 : Form
    {
        
       double odenecek = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_hesapla_Click(object sender, EventArgs e)
        {
            double urunKDVsiz = Convert.ToDouble(textBox_UrunFiyat.Text);
           
            double urunSonFiyat = 0;
            if (radioButton_ogrenci.Checked == true)
            {
                urunSonFiyat = (urunKDVsiz - (urunKDVsiz * 0.05));
                odenecek += urunSonFiyat;
            }
            else if (radioButton_yasli.Checked == true)
            {
                urunSonFiyat = Math.Round((urunKDVsiz - (urunKDVsiz * 0.03)), 2);
                odenecek += urunSonFiyat;
            }
            else if (radioButton_hicbiri.Checked == true)
            {
                urunSonFiyat = Math.Round(urunKDVsiz, 2);
                odenecek += urunSonFiyat;
            }
            listBox_AlisverisDetay.Items.Add(textBox_UrunAd.Text + " " + urunSonFiyat + " TL");
            textBox_tutar.Text = odenecek+" TL ÖDENECEK" ;
         
            MessageBox.Show("TOPLAM TUTAR :" + odenecek + "TL");
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            listBox_AlisverisDetay.Items.Clear();
            textBox_tutar.Clear();
            odenecek = 0;
            textBox_UrunAd.Clear();
            textBox_UrunFiyat.Clear();
        }
    }
}
