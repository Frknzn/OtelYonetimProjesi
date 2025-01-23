using MySql.Data.MySqlClient;
using OtelYönetimProjesi.Business_Layer;
using OtelYönetimProjesi.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYönetimProjesi
{
    public partial class Form1 : Form
    {


        private Yonetici_Bussiness_Layer yoneticibussinesslayer;
        

        public Form1()
        {
            InitializeComponent();
            
            yoneticibussinesslayer = new Yonetici_Bussiness_Layer();
            
         
        }


        private void ÇıkısBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            
            string YoneticiKimlik = GirisKimliktxt.Text;
            string YoneticiSifre = GirisSifre.Text;

            
            var(girisbasarili , mesaj) = Yonetici_Bussiness_Layer.YoneticiGirisBLL(YoneticiKimlik, YoneticiSifre);
            if (girisbasarili)
            {               
                MessageBox.Show(mesaj ,"Giriş başarılı");
                Yonetici_Ana_Ekran fr = new Yonetici_Ana_Ekran();
                fr.Show();
                this.Hide();
            }else
            {
                MessageBox.Show(mesaj);
            }

          
           
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KurtarmaLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Guvenlik_Sifre_Yenileme fr = new Guvenlik_Sifre_Yenileme();
            fr.Show();

        }
    }
}
