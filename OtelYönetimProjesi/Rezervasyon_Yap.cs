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
    public partial class Rezervasyon_Yap : UserControl
    {
        private readonly Yonetici_Bussiness_Layer OdaRezervasyon;
        public Rezervasyon_Yap()
        {
            InitializeComponent();
            OdaRezervasyon = new Yonetici_Bussiness_Layer();

            if (GirisTarihiDateTime == null || CikisTarihiDateTime == null || OdaListeTablo == null)
            {
                MessageBox.Show("Form kontrolleri düzgün oluşturulamadı!");
                
            }

        }

        private void GirisTarihiDateTime_ValueChanged(object sender, EventArgs e)
        {
            CikisTarihiDateTime.MinDate = GirisTarihiDateTime.Value.AddDays(1);
            if (CikisTarihiDateTime.MinDate <= GirisTarihiDateTime.Value)
            {
                CikisTarihiDateTime.Value = GirisTarihiDateTime.Value.AddDays(1);
            }

        }

        private void BosOdaListelebtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (GirisTarihiDateTime == null || CikisTarihiDateTime == null)
                {
                    MessageBox.Show("Tarih seçim alanları oluşturulmamış!");
                    return;
                }

                if (OdaListeTablo == null)
                {
                    MessageBox.Show("DataGridView oluşturulmamış!");
                    return;
                }

                

                
                var sonucTablo = OdaRezervasyon.MusaitOdalarıGetirBLL(
                    GirisTarihiDateTime.Value,
                    CikisTarihiDateTime.Value
                );

                
                if (sonucTablo == null)
                {
                    MessageBox.Show("Veri getirilemedi!");
                    return;
                }

                
                OdaListeTablo.DataSource = sonucTablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                BosOdaListelebtn.Enabled = true;
            }
        }

        private void MusteriListeTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BosOdalarıListele()
        {
            try
            {
                OdaListeTablo.DataSource = OdaRezervasyon.BosOdalarıGetirBLL(GirisTarihiDateTime.Value,CikisTarihiDateTime.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MusteriListele()
        {
            try
            {
                MusteriListeTablo.DataSource = Yonetici_DAL.MusteriGoruntule(MusteriListeTablo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Rezervasyon_Yap_Load(object sender, EventArgs e)
        {
            MusteriListele();
            
            
            Yonetici_DAL.MusteriGoruntule(MusteriListeTablo);
        }

        private void RezervasyonOnaybtn_Click(object sender, EventArgs e)
        {
            if (OdaListeTablo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir oda seçiniz");
                return;
            }
            if(MusteriListeTablo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
                return;
            }

            try
            {

                int odaId = Convert.ToInt32(OdaListeTablo.CurrentRow.Cells["odaid"].Value);
                int odaNumarasi = Convert.ToInt32(OdaListeTablo.CurrentRow.Cells["odanumarasi"].Value);
                
                decimal odaFiyat = Convert.ToDecimal(Ucrettxtbox.Text);

                int musteriId = Convert.ToInt32(MusteriListeTablo.CurrentRow.Cells["musteri_id"].Value);
                long musteriKimlik = Convert.ToInt64(MusteriListeTablo.CurrentRow.Cells["musteri_kimlik_numarasi"].Value);
                string musteriİsim = MusteriListeTablo.CurrentRow.Cells["musteri_isim"].Value.ToString();
                string musteriSoyisim = MusteriListeTablo.CurrentRow.Cells["musteri_soyisim"].Value.ToString();
                long musteriTel = Convert.ToInt64(MusteriListeTablo.CurrentRow.Cells["musteri_tel_numarasi"].Value);
                long musteriKart = Convert.ToInt64(MusteriListeTablo.CurrentRow.Cells["musteri_odeme_kart"].Value);

                DateTime girisTarihi = GirisTarihiDateTime.Value;
                DateTime cikisTarihi = CikisTarihiDateTime.Value;

                var (basarili, mesaj, tutar) = Yonetici_Bussiness_Layer.RezervasyonYapBLL(odaId, musteriId, girisTarihi, cikisTarihi, musteriKimlik, musteriTel, musteriKart, musteriİsim, musteriSoyisim, odaNumarasi, odaFiyat);
                MessageBox.Show(mesaj);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void OdaListeTablo_SelectionChanged(object sender, EventArgs e)
        {
            if (OdaListeTablo.SelectedRows.Count >0 )
            {
                decimal fiyat = Convert.ToDecimal(OdaListeTablo.SelectedRows[0].Cells["odafiyat"].Value);
                Ucrettxtbox.Text = fiyat.ToString("N2");
            }
        }

        private void Ucrettxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
