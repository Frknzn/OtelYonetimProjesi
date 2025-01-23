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
    public partial class Rezervasyon_İptal : UserControl
    {
        public Rezervasyon_İptal()
        {
            InitializeComponent();
        }

        private void RezervasyonListelbl_Click(object sender, EventArgs e)
        {

        }

        private void RezevasyonListelebtn_Click(object sender, EventArgs e)
        {
            if (Yonetici_DAL.RezervasyonGoruntule(RezervasyonListeGridView))
            {

            }
        }

        private void Rezervasyonİptalbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (RezervasyonListeGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen iptal edilecek rezervasyonu seçin.");
                    return;
                }

                Guvenlik_Katmanı guvenlik = new Guvenlik_Katmanı();
                guvenlik.ShowDialog();


                if (guvenlik.Onay)
                {
                    int RezervasyonlId = Convert.ToInt32(RezervasyonListeGridView.SelectedRows[0].Cells["rezervasyon_id"].Value);


                    if (Yonetici_DAL.Rezervasyonİptal(RezervasyonlId))
                    {
                        MessageBox.Show("Rezervasyon başarıyla iptal edildi");
                        Yonetici_DAL.RezervasyonGoruntule(RezervasyonListeGridView);

                    }
                    else MessageBox.Show("Hata : Rezervasyon iptal edilemedi");
                }
                else
                {
                    MessageBox.Show("Hata2 : Rezervasyon iptal edilemedi");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata :" + ex.Message);
            }
        }

        private void Rezervasyon_İptal_Load(object sender, EventArgs e)
        {
            Yonetici_DAL.RezervasyonGoruntule(RezervasyonListeGridView);
        }
    }
}
