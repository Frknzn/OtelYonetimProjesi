using MySql.Data.MySqlClient;
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
    public partial class Rezervasyon_İslem : UserControl
    {
        
        public Rezervasyon_İslem()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (BaglantiAc.baglantiGetir())
            //{
            //    if (Yonetici_DAL.MusteriGoruntule(MusteriListGridView))
            //    {

            //    }
            //}           
        }

        private void RezervasyonOnaybtn_Click(object sender, EventArgs e)
        {
            //if (OdaListeGridView.CurrentRow == null || MusteriListGridView.CurrentRow == null)
            //{
            //    MessageBox.Show("Lütfen müşteri ve oda seçiniz");
            //    return;
            //}
            //try
            //{
            //    int OdaId = Convert.ToInt32(OdaListeGridView.CurrentRow.Cells["oda_id"].Value);
            //    int MusteriId = Convert.ToInt32(MusteriListGridView.CurrentRow.Cells["musteri_id"].Value);
            //    long MusteriKimlik = Convert.ToInt64(MusteriListGridView.CurrentRow.Cells["musteri_kimlik_numarasi"].Value);
            //    int OdaNumarasi = Convert.ToInt32(OdaListeGridView.CurrentRow.Cells["oda_numarasi"].Value);
            //    string Musteriİsim = MusteriListGridView.CurrentRow.Cells["musteri_isim"].Value.ToString();
            //    string MusteriSoyisim = MusteriListGridView.CurrentRow.Cells["musteri_soyisim"].Value.ToString();
            //    DateTime GirisTarihi = dateTimePicker1.Value;
            //    DateTime CıkısTarihi = dateTimePicker2.Value;
            //    int Ücret = Convert.ToInt32(OdaListeGridView.CurrentRow.Cells["oda_fiyat"].Value);
            //    long MusteriTelNo = Convert.ToInt64(MusteriListGridView.CurrentRow.Cells["musteri_tel_numarasi"].Value);
            //    long MusteriOdemeKart = Convert.ToInt64(MusteriListGridView.CurrentRow.Cells["musteri_odeme_kart"].Value);
                
            //    decimal toplamFiyat = Yonetici_DAL.FaturaHesapla(GirisTarihi, CıkısTarihi, OdaId);
            //    if(toplamFiyat <= 0)
            //    {
            //        MessageBox.Show("Fatura hesaplanırken bir hata oluştu");
            //        return;
            //    }

            //    bool islem = Yonetici_DAL.RezervasyonYap(OdaId, MusteriId, GirisTarihi, CıkısTarihi, MusteriKimlik, Musteriİsim, MusteriSoyisim, OdaNumarasi);               
            //    if (islem) 
            //    {
            //        MessageBox.Show("Rezervasyon yapıldı"); 

            //        int RezervasyonId = Yonetici_DAL.SonRezervasyonIdGetir();
            //        if (RezervasyonId <= 0)
            //        {
            //            MessageBox.Show("Hata1 : Fatura oluşturulurken bir hata oluştu");
            //            return;
            //        }

            //        bool faturaİslem = Yonetici_DAL.FaturaKaydet(Convert.ToInt32(toplamFiyat), Musteriİsim, MusteriSoyisim, MusteriKimlik, MusteriTelNo, MusteriOdemeKart, RezervasyonId, OdaNumarasi, GirisTarihi, CıkısTarihi);
            //        if (!faturaİslem)
            //        {
            //            MessageBox.Show("Hata2 :Fatura kaydedilirken hata oluştu");
            //            return;
            //        }
            //        MessageBox.Show("Faturanız oluşturuldu");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Hata : Rezervasyon yapılamadı");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("HATA" + ex.Message);
            //}
            
        }

        private void RezervasyonOdaListelebtn_Click(object sender, EventArgs e)
        {
            //if (Yonetici_DAL.OdaGoruntule(OdaListeGridView))
            //{
                

            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker dateTimePicker1 = sender as DateTimePicker;

            //if (dateTimePicker1 != null)
            //{              
            //    DateTime selectedDate = dateTimePicker1.Value;
               
            //    if (selectedDate < DateTime.Today)
            //    {
            //        MessageBox.Show("Lütfen bugünden sonraki bir tarih seçin!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        dateTimePicker1.Value = DateTime.Today; 
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Seçilen Tarih : {selectedDate.ToShortDateString()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker dateTimePicker2 = sender as DateTimePicker;

            //if (dateTimePicker2 != null)
            //{               
            //    DateTime selectedDate2 = dateTimePicker2.Value;
                
            //    DateTime selectedDate1 = dateTimePicker1.Value;
               
            //    if (selectedDate2 <= selectedDate1)
            //    {
            //        MessageBox.Show("Çıkış tarihi, giriş tarihinden sonraki bir tarih olmalıdır!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        dateTimePicker2.Value = selectedDate1; 
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Seçilen Çıkış Tarihi : {selectedDate2.ToShortDateString()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }
        private void MusteriListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rezervasyon_İslem_Load(object sender, EventArgs e)
        {

        }
    }
}
