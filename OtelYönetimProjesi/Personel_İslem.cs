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
    public partial class Personel_İslem : UserControl
    {
        public Personel_İslem()
        {
            InitializeComponent();
        }

        private void PersonelKaydetbtn_Click(object sender, EventArgs e)
        {
            string Personelİsim = PersonelİsimEkletxt.Text;
            string PersonelSoyisim = PersonelSoyisimEkletxt.Text;
            string PersonelKimlik = PersonelKimlikEkletxt.Text;
            string PersonelPozisyon = PersonelPozisyonEkletxt.Text;
            string PersonelTelNumara = PersonelTelEkletxt.Text;

            
            var (basarili, mesaj) = Yonetici_Bussiness_Layer.PersonelKaydetBLL(Personelİsim, PersonelSoyisim, PersonelKimlik, PersonelPozisyon, PersonelTelNumara);
            if (basarili)
            {
                MessageBox.Show(mesaj);
                Yonetici_DAL.PersonelGoruntule(PersonelListeGridView);
            }
            else
            {
                MessageBox.Show(mesaj);
            }
        }

        private void PersonelIslemlbl_Click(object sender, EventArgs e)
        {

        }

        private void Personel_İslem_Load(object sender, EventArgs e)
        {
            Yonetici_DAL.PersonelGoruntule(PersonelListeGridView);
        }
        private int selectedPersonelID;
        private void PersonelListeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = PersonelListeGridView.Rows[e.RowIndex];
                PersonelİsimEkletxt.Text = row.Cells["personel_isim"].Value.ToString();
                PersonelSoyisimEkletxt.Text = row.Cells["personel_soyisim"].Value.ToString();
                PersonelPozisyonEkletxt.Text = row.Cells["personel_pozisyon"].Value.ToString();
                PersonelTelEkletxt.Text = row.Cells["personel_tel_numarasi"].Value.ToString();
                selectedPersonelID = Convert.ToInt32(row.Cells["personel_id"].Value);
            }
        }

        private void PersonelListeGorbtn_Click(object sender, EventArgs e)
        {
            if (Yonetici_DAL.PersonelGoruntule(PersonelListeGridView))
            {

            }
        }

        private void PersonelSilbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (PersonelListeGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek personeli seçin.");
                    return;
                }

                Guvenlik_Katmanı guvenlik = new Guvenlik_Katmanı();
                guvenlik.ShowDialog();


                if (guvenlik.Onay)
                {
                    int PersonelId = Convert.ToInt32(PersonelListeGridView.SelectedRows[0].Cells["personel_id"].Value);
                  

                    if (Yonetici_Bussiness_Layer.PersonelSilBLL(PersonelId))
                    {
                        MessageBox.Show("Personel başarıyla güncellendi");
                        Yonetici_DAL.PersonelGoruntule(PersonelListeGridView);
                    }
                    else
                    {
                        MessageBox.Show("Hata : Personel siliemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Hata2 : Personel silinemedi");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
        }

        private void PersonelGuncellebtn_Click(object sender, EventArgs e)
        {
            var (basarili, mesaj) = Yonetici_Bussiness_Layer.PersonelGuncelleBLL(PersonelİsimEkletxt.Text, PersonelSoyisimEkletxt.Text, PersonelTelEkletxt.Text, PersonelPozisyonEkletxt.Text, selectedPersonelID);
            MessageBox.Show(mesaj);
            if (basarili)
            {
                MessageBox.Show(mesaj);
            }
        }
    }
}
