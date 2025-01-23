using OtelYönetimProjesi.Business_Layer;
using OtelYönetimProjesi.Data_Access_Layer;
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
    public partial class Oda_Islem : UserControl
    {
        public Yonetici_Bussiness_Layer yoneticibussinesslayer;
        public Oda_Islem()
        {
            InitializeComponent();
            yoneticibussinesslayer = new Yonetici_Bussiness_Layer();
        }

        private void OdaKaydetbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OdaNumaratxt.Text) || string.IsNullOrEmpty(OdaTurtxt.Text) || string.IsNullOrEmpty(OdaFiyattxt.Text))
            {
                return;
            }
            string OdaNumara = OdaNumaratxt.Text;
            string OdaTur = OdaTurtxt.Text;
            string OdaFiyat = OdaFiyattxt.Text;

            //bool kayıt = Yonetici_DAL.OdaKaydet(OdaNumara, OdaTur, OdaFiyat);
            (bool basarili ,string mesaj) = Yonetici_Bussiness_Layer.OdaKaydetBLL(OdaNumara, OdaTur, OdaFiyat);
            if (basarili)
            {
                MessageBox.Show("Oda sisteme başarıyla kaydedildi");
                Yonetici_DAL.OdaGoruntule(OdaListeGridView);
            }
            else
            {
                MessageBox.Show("Hata : Oda sisteme kaydedilemedi : " + mesaj);
            }
        }

        private void OdaListeGorbtn_Click(object sender, EventArgs e)
        {
            if (Yonetici_DAL.OdaGoruntule(OdaListeGridView))
            {

            }
        }

        private void OdaSilbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (OdaListeGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek odayı seçin.");
                    return;
                }

                Guvenlik_Katmanı guvenlik = new Guvenlik_Katmanı();
                guvenlik.ShowDialog();


                if (guvenlik.Onay)
                {
                    int OdaId = Convert.ToInt32(OdaListeGridView.SelectedRows[0].Cells["oda_id"].Value);


                    //if (Yonetici_DAL.OdaSil(OdaId))
                    //{
                    //    MessageBox.Show("Oda başarıyla silindi");
                    //    Yonetici_DAL.OdaGoruntule(OdaListeGridView);

                    //}
                    //else MessageBox.Show("Hata : Oda silinemedi");

                    if (Yonetici_Bussiness_Layer.OdaSilBLL(OdaId))
                    {
                        MessageBox.Show("Oda başarıyla silindi");
                        Yonetici_DAL.OdaGoruntule(OdaListeGridView);
                    }
                    else
                    {
                        MessageBox.Show("Hata : Oda silinemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Hata2 : Oda silinemedi");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
        }

        private void OdaTurListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OdaGuncellebtn_Click(object sender, EventArgs e)
        {
            var (basarili, mesaj) = Yonetici_Bussiness_Layer.OdaGuncelleBLL(OdaNumaratxt.Text, OdaTurtxt.Text, OdaFiyattxt.Text, selectedOdaId);
            MessageBox.Show(mesaj);
            if (basarili)
            {
                MessageBox.Show(mesaj);
            }
        }

        private int selectedOdaId;
        private void OdaListeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = OdaListeGridView.Rows[e.RowIndex];
               // OdaNumaratxt.Text = row.Cells["oda_numarasi"].Value.ToString();
                OdaTurtxt.Text = row.Cells["oda_tur"].Value.ToString();
                OdaFiyattxt.Text = row.Cells["oda_fiyat"].Value.ToString();
                selectedOdaId = Convert.ToInt32(row.Cells["oda_id"].Value);
            }
        }

        private void Oda_Islem_Load(object sender, EventArgs e)
        {
            Yonetici_DAL.OdaGoruntule(OdaListeGridView);
        }
    }
}
