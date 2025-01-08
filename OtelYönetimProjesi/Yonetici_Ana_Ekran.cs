using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYönetimProjesi
{
    public partial class Yonetici_Ana_Ekran : Form
    {
        public Yonetici_Ana_Ekran()
        {
            InitializeComponent();
            YoneticiYanPanel.Width = 0;
            isSidebarExpanded = false;
           
        }

        

        private void AnaEkranCıkıs_Click(object sender, EventArgs e)
        {
            

        }

        private void Yonetici_Ana_Ekran_Load(object sender, EventArgs e)
        {

        }

        private void OdalariGorbtn_Click(object sender, EventArgs e)
        {

        }

        private void musteri_Kaydet1_Load(object sender, EventArgs e)
        {

        }

        private void RezervasyonYapBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void PersonelBilgibtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Müsteriİslembtn_Click(object sender, EventArgs e)
        {
           
            
        }

        private void FaturaKayıtlarıbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Rezervasyonİslembtn_Click(object sender, EventArgs e)
        {
           
            
        }

        private void rezervasyon_İslem1_Load(object sender, EventArgs e)
        {

        }

        private void Ayarlar_Click(object sender, EventArgs e)
        {
            
        }

        private void Rezervasyonİptalbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void YeniYoneticiEklebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AnaSayfabtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                YoneticiYanPanel.Width -= 10;
                if (YoneticiYanPanel.Width <= 0)
                {
                    SidebarTimer.Stop();
                    isSidebarExpanded = false;
                }
            }
            else
            {
                YoneticiYanPanel.Width += 10;
                if (YoneticiYanPanel.Width >= 334)
                {
                    SidebarTimer.Stop();
                    isSidebarExpanded = true;
                }
            }
        }
        private bool isSidebarExpanded = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void AnaSayfabtn_Click_1(object sender, EventArgs e)
        {
            GostergePanel.Height = AnaSayfabtn.Height;
            GostergePanel.Top = AnaSayfabtn.Top;
            yonetici_Ana_Sayfa1.BringToFront();
        }

        private void Müsteriİslembtn_Click_1(object sender, EventArgs e)
        {

            GostergePanel.Height = Müsteriİslembtn.Height;
            GostergePanel.Top = Müsteriİslembtn.Top;
            musteri_İslem1.BringToFront();
        }

        private void Rezervasyonİslembtn_Click_1(object sender, EventArgs e)
        {
            GostergePanel.Height = Rezervasyonİslembtn.Height;
            GostergePanel.Top = Rezervasyonİslembtn.Top;
            rezervasyon_İslem1.BringToFront();
        }

        private void Rezervasyonİptalbtn_Click_1(object sender, EventArgs e)
        {
            GostergePanel.Height = Rezervasyonİptalbtn.Height;
            GostergePanel.Top = Rezervasyonİptalbtn.Top;
            rezervasyon_İptal1.BringToFront();
        }

        private void Odaİslembtn_Click(object sender, EventArgs e)
        {
            GostergePanel.Height = Odaİslembtn.Height;
            GostergePanel.Top = Odaİslembtn.Top;
            oda_Islem1.BringToFront();
        }

        private void Personelİslembtn_Click(object sender, EventArgs e)
        {
            GostergePanel.Height = Personelİslembtn.Height;
            GostergePanel.Top = Personelİslembtn.Top;
            personel_İslem1.BringToFront();
        }

        private void YeniYoneticiEklebtn_Click_1(object sender, EventArgs e)
        {
            GostergePanel.Height = YeniYoneticiEklebtn.Height;
            GostergePanel.Top = YeniYoneticiEklebtn.Top;
            yonetici_Kayıt1.BringToFront();
        }

        private void FaturaKayıtlarıbtn_Click_1(object sender, EventArgs e)
        {
            GostergePanel.Height = FaturaKayıtlarıbtn.Height;
            GostergePanel.Top = FaturaKayıtlarıbtn.Top;
            fatura_Kayıt_Ekranı1.BringToFront();
        }

        private void Ayarlar_Click_1(object sender, EventArgs e)
        {
            GostergePanel.Height = Ayarlar.Height;
            GostergePanel.Top = Ayarlar.Top;
            hesap_Ayarları1.BringToFront();
        }

        private void AnaEkranCıkıs_Click_1(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void YoneticiYanPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yonetici_Ana_Sayfa1_Load(object sender, EventArgs e)
        {

        }
    }
}
