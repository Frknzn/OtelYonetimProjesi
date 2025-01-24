using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelYönetimProjesi.Business_Layer;
using OtelYönetimProjesi.Data_Access_Layer;
using OtelYönetimProjesi.Entity_Layer;


namespace OtelYönetimProjesi
{
    public partial class Musteri_İslem : UserControl
    {

        private Yonetici_Bussiness_Layer yoneticibussinesslayer;

        public Musteri_İslem()
        {
            InitializeComponent();


            yoneticibussinesslayer = new Yonetici_Bussiness_Layer();


        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Müsteriİsimtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriKaydetbtn_Click(object sender, EventArgs e)
        {
            string MusteriKimlik = MusteriKimliktxt.Text;
            string Musteriİsim = Musteriİsimtxt.Text;
            string MusteriSoyisim = MusteriSoyisimtxt.Text;
            string MusteriTelNo = MusteriTeltxt.Text;
            string MusteriOdemeKart = MusteriKarttxt.Text;

           
           var(basarili, mesaj) = Yonetici_Bussiness_Layer.MusteriKaydetBLL(Musteriİsim, MusteriSoyisim, MusteriKimlik, MusteriTelNo, MusteriOdemeKart);
            if(basarili)
            {
                MessageBox.Show( mesaj);
                Yonetici_DAL.MusteriGoruntule(MusteriListeGridView);
                
            }
            else
            {
                MessageBox.Show(mesaj);
            }


        }

        private void MusteriListeGorbtn_Click(object sender, EventArgs e)
        {
            if (Yonetici_DAL.MusteriGoruntule(MusteriListeGridView))
            {
                
            }
               
        }

        private void MusteriSilbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (MusteriListeGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek müşteriyi seçin.");
                    return;
                }

                Guvenlik_Katmanı guvenlik = new Guvenlik_Katmanı();
                guvenlik.ShowDialog();


                if (guvenlik.Onay)
                {
                    int MusteriId = Convert.ToInt32(MusteriListeGridView.SelectedRows[0].Cells["musteri_id"].Value);


                    

                    if (Yonetici_Bussiness_Layer.MusteriSilBLL(MusteriId))
                    {
                        MessageBox.Show("Müşteri başarıyla silindi");
                        Yonetici_DAL.MusteriGoruntule(MusteriListeGridView);
                    }
                    else
                    {
                        MessageBox.Show("Hata : Müşteri silinemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Hata2 : Müşteri silinemedi");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
            
                             
        

           
        }
        private int selectedMusteriID;
        private void MusteriListeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = MusteriListeGridView.Rows[e.RowIndex];
                Musteriİsimtxt.Text = row.Cells["musteri_isim"].Value.ToString();
                MusteriSoyisimtxt.Text = row.Cells["musteri_soyisim"].Value.ToString();
                MusteriTeltxt.Text = row.Cells["musteri_tel_numarasi"].Value.ToString();
                MusteriKarttxt.Text = row.Cells["musteri_odeme_kart"].Value.ToString();
                selectedMusteriID = Convert.ToInt32(row.Cells["musteri_id"].Value);

            }
        }

        private void MusteriGuncellebtn_Click(object sender, EventArgs e)
        {
            var (basarili, mesaj) = Yonetici_Bussiness_Layer.MusteriGuncelleBLL(Musteriİsimtxt.Text, MusteriSoyisimtxt.Text, MusteriTeltxt.Text, MusteriKarttxt.Text, selectedMusteriID);
            MessageBox.Show(mesaj);
            if (basarili)
            {
                MessageBox.Show(mesaj);
                
            }
                     
        }

        private void Musteri_İslem_Load(object sender, EventArgs e)
        {
            Yonetici_DAL.MusteriGoruntule(MusteriListeGridView);
        }
    }
}
