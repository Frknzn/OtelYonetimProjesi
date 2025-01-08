using OtelYönetimProjesi.Business_Layer;
using OtelYönetimProjesi.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYönetimProjesi
{
    public partial class Guvenlik_Sifre_Yenileme : Form
    {

        private readonly Yonetici_Bussiness_Layer Yonetici_Bll;
        private string Yonetici_Kimlik;
        public Guvenlik_Sifre_Yenileme()
        {
            InitializeComponent();
            Yonetici_Bll = new Yonetici_Bussiness_Layer();
        }

        private void GuvenlikCıkısbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GuvenlikKimlikOnaybtn_Click(object sender, EventArgs e)
        {
            try
            {
                Yonetici_Kimlik = GuvenlikKimliktxt.Text.Trim();
                string guvenlikSorusu = Yonetici_Bll.GuvenlikSorusuGetirBLL(Yonetici_Kimlik);

                if (!string.IsNullOrEmpty(guvenlikSorusu) )
                {
                    GuvenlikSorutxt.Text = guvenlikSorusu;
                    GuvenlikCevaptxt.Enabled = true;
                    GuvenlikCevapOnaybtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GuvenlikCevapOnaybtn_Click(object sender, EventArgs e)
        {
            string cevap = GuvenlikCevaptxt.Text.Trim();

            if (Yonetici_Bll.GuvenlikCevapKontrolBLL(Yonetici_Kimlik,cevap) )
            {
                GuvenlikYeniSifretxt.Enabled = true;
                GuvenlikYeniSifreTekrartxt.Enabled = true;
                GuvenlikYeniSifreKaydetbtn.Enabled = true;
                MessageBox.Show("Guvenlik cevabı doğru");
            }
            else
            {
                MessageBox.Show("Guvenlik cevabı yanlış");
            }
        }

        private void GuvenlikYeniSifreKaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string yeniSifre = GuvenlikYeniSifretxt.Text;
                string sifreTektar = GuvenlikYeniSifreTekrartxt.Text;

                if(Yonetici_Bll.GuvenlikSifreGuncelleBLL(Yonetici_Kimlik, yeniSifre , sifreTektar))
                {
                    MessageBox.Show("Şifreniz güncellendi");
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
