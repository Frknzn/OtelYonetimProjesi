using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Data.Common;
using System.Runtime.InteropServices;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OtelYönetimProjesi.Entity_Layer;
using System.Runtime.CompilerServices;

namespace OtelYönetimProjesi.Data_Access_Layer
{

    //public static class GirenYoneticiID
    //{
    //    public static int GirisYapanYoneticiID { get; set; }
    //}
    public class Yonetici_DAL
    {
        
        public static bool YoneticiGiris (string YoneticiKimlik, string YoneticiSifre)  
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                string query = "Select yonetici_id From Yoneticiler Where yonetici_kimlik = @yoneticikimlik and yonetici_sifre = @yoneticisifre";
                using (MySqlCommand komut1 = new MySqlCommand(query, baglanti))
                {
                    komut1.Parameters.AddWithValue("@yoneticisifre", YoneticiSifre);
                    komut1.Parameters.AddWithValue("@yoneticikimlik", YoneticiKimlik);

                    object sonuc = komut1.ExecuteScalar();
                    
                    if (sonuc != null)
                    {
                        Giren_Yonetici_ID.GirisYapanYoneticiID = Convert.ToInt32(sonuc);
                        return true;    
                    }
                    return false;
                    //using (MySqlDataReader reader = komut1.ExecuteReader())
                    //{
                    //    return reader.HasRows;
                    //}
                }
            }
        }

        public static bool MusteriKaydet (string MusteriKimlik, string Musteriİsim, string MusteriSoyisim, string MusteriTelNo, string MusteriOdemeKart)  
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())   
            {
                if( baglanti.State != ConnectionState.Open)
                {
                  baglanti.Open() ;
                }
                string query = "Insert Into Musteriler(musteri_kimlik_numarasi, musteri_isim, musteri_soyisim, musteri_tel_numarasi, musteri_odeme_kart) values (@musterikimliknumarasi, @musteriisim, @musterisoyisim, @musteritelnumarasi, @musteriodemekart)";
                using (MySqlCommand komut2 = new MySqlCommand (query,baglanti))
                {
                    komut2.Parameters.AddWithValue("@musterikimliknumarasi", MusteriKimlik);
                    komut2.Parameters.AddWithValue("@musteriisim", Musteriİsim);
                    komut2.Parameters.AddWithValue("@musterisoyisim", MusteriSoyisim);
                    komut2.Parameters.AddWithValue("@musteritelnumarasi", MusteriTelNo);
                    komut2.Parameters.AddWithValue("@musteriodemekart", MusteriOdemeKart);

                    int rowsAffected = komut2.ExecuteNonQuery();                  
                }
                return true;
            }                      
        }

        public static bool MusteriKimlikKontrol (string MusteriKimlik)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir ())
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open() ;

                    }
                    string query = "Select Count(*)  From Musteriler Where musteri_kimlik_numarasi = @musterikimliknumarasi";
                    MySqlCommand komut = new MySqlCommand (query, baglanti);
                    komut.Parameters.AddWithValue("@musterikimliknumarasi", MusteriKimlik);
                    int kayitKontrol = Convert.ToInt32 (komut.ExecuteScalar());
                    return kayitKontrol > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool PersonelKaydet(string Personelİsim, string PersonelSoyisim, string PersonelKimlik, string PersonelPozisyon, string PersonelTelNumara)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir()) 
            {
                if(baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open() ;
                }
                string query = "Insert Into Personeller (personel_isim, personel_soyisim, personel_kimlik_numarasi, personel_pozisyon, personel_tel_numarasi) values (@personelisim, @personelsoyisim, @personelkimliknumarasi, @personelpozisyon, @personeltelnumarasi)";
                using (MySqlCommand komut3 = new MySqlCommand(query,baglanti))
                {
                    komut3.Parameters.AddWithValue("@personelisim", Personelİsim);
                    komut3.Parameters.AddWithValue("@personelsoyisim", PersonelSoyisim);
                    komut3.Parameters.AddWithValue("@personelkimliknumarasi", PersonelKimlik);
                    komut3.Parameters.AddWithValue("@personelpozisyon", PersonelPozisyon);
                    komut3.Parameters.AddWithValue("@personeltelnumarasi", PersonelTelNumara);

                    int rowsAffected = komut3 .ExecuteNonQuery();                                    
                }
                return true;                                                            
            }
        }

        public static bool PersonelKimlikKontrol(string PersonelKimlik)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open() ;
                    }

                    string query = "Select * Count From Personeller Where personel_kimlik_numarasi = @personelkimliknumarasi";
                    MySqlCommand komut = new MySqlCommand (query,baglanti);
                    komut.Parameters.AddWithValue("@personelkimliknumarasi", PersonelKimlik);
                    int kayitKontrol = Convert.ToInt32 (komut.ExecuteScalar());
                    return kayitKontrol > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool OdaKaydet(string OdaNumara, string OdaTur, string OdaFiyat)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
            {
                if(baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                string query = "Insert Into Odalar (oda_numarasi, oda_tur, oda_fiyat) values (@odanumarasi, @odatur, @odafiyat)";
                using (MySqlCommand komut4 =  new MySqlCommand(query,baglanti))
                {
                    komut4.Parameters.AddWithValue("@odanumarasi", OdaNumara);
                    komut4.Parameters.AddWithValue("@odatur", OdaTur);
                    komut4.Parameters.AddWithValue("@odafiyat", OdaFiyat);

                    int rowsAffected = komut4 .ExecuteNonQuery();

                }
                return true;
            }
           
        }

        public static bool OdaNumaraKontrol(string OdaNumara)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
            {
                if(baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                string query = "Select Count(*) From Odalar Where oda_numarasi = @odanumarasi";
                MySqlCommand komut = new MySqlCommand (query,baglanti);
                komut.Parameters.AddWithValue("@odanumarasi", OdaNumara);
                int kayitKontrol=Convert.ToInt32(komut.ExecuteScalar());
                return kayitKontrol > 0;
            }
        }

        //public static bool OdaRezervasonTarihiUygunMu(int OdaId, DateTime GirisTarihi, DateTime CıkısTarihi)
        //{
        //    using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //    {
        //        try
        //        {
        //            if (baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();
        //            }
        //            string query = "SELECT COUNT(*) FROM Rezervasyonlar WHERE oda_id = @odaid AND (giris_tarih <= @cikistarih AND cikis_tarih >= @giristarih)";
        //            using (MySqlCommand komut5 = new MySqlCommand(query, baglanti))
        //            {
        //                komut5.Parameters.AddWithValue("@odaid", OdaId);
        //                komut5.Parameters.AddWithValue("@giristarih", GirisTarihi.Date);
        //                komut5.Parameters.AddWithValue("@cikistarih", CıkısTarihi.Date);

        //                int rezervasyonsayisi = Convert.ToInt32(komut5.ExecuteScalar());
        //                return rezervasyonsayisi == 0;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Tarih kontrolü sırasında hata:" + ex.Message);
        //            return false;
        //        }
        //    }
        //}



        //public static bool RezervasyonYap(int OdaId, int MusteriId, DateTime GirisTarihi, DateTime CıkısTarihi, long MusteriKimlik, string Musteriİsim, string MusteriSoyisim, int OdaNumarasi)
        //{
        //    if (OdaRezervasonTarihiUygunMu(OdaId, GirisTarihi, CıkısTarihi))
        //    {
        //        using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //        {
        //            if (baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();
        //            }
        //            string query = "Insert Into Rezervasyonlar (oda_id, musteri_id, giris_tarih, cikis_tarih, musteri_kimlik_numarasi, musteri_isim, musteri_soyisim, oda_numarasi) values (@odaid, @musteri_id, @giristarih, @cikistarih, @musterikimliknumarasi, @musteriisim, @musterisoyisim, @odanumarasi)";
        //            MySqlCommand komut6 = new MySqlCommand(query, baglanti);
        //            komut6.Parameters.AddWithValue("@odaid", OdaId);
        //            komut6.Parameters.AddWithValue("@giristarih", GirisTarihi);
        //            komut6.Parameters.AddWithValue("@cikistarih", CıkısTarihi);
        //            komut6.Parameters.AddWithValue("@musteri_id", MusteriId);
        //            komut6.Parameters.AddWithValue("@musterikimliknumarasi", MusteriKimlik);
        //            komut6.Parameters.AddWithValue("@musteriisim", Musteriİsim);
        //            komut6.Parameters.AddWithValue("@musterisoyisim", MusteriSoyisim);
        //            komut6.Parameters.AddWithValue("@odanumarasi", OdaNumarasi);

        //            int rowsAffected = komut6.ExecuteNonQuery();
        //            return rowsAffected > 0;
        //        }

        //    }
        //    else
        //    {

        //        return false;
        //    }
        //}




        public static bool MusteriSil(int MusteriId)
        {
            try
            {
                using(MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Delete From Musteriler Where musteri_id = @musteriid";
                    MySqlCommand komut7 = new MySqlCommand(query, baglanti);
                    komut7.Parameters.AddWithValue("@musteriid", MusteriId);
                    int rowsAffected = komut7.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri silme sırasında hata : " + ex.Message);
                return false;
            }
        }

        public static bool PersonelSil(int PersonelId)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Delete From Personeller Where personel_id = @personelid";
                    MySqlCommand komut8 = new MySqlCommand(query, baglanti);
                    komut8.Parameters.AddWithValue("@personelid", PersonelId);
                    int rowsAffected = komut8.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel silme sırasında hata : " + ex.Message);
                return false;
            }
        }

        public static bool OdaSil(int OdaId)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Delete From Odalar Where oda_id = @odaid";
                    MySqlCommand komut9 = new MySqlCommand(query, baglanti);
                    komut9.Parameters.AddWithValue("@odaid", OdaId);
                    int rowsAffected = komut9.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda silme sırasında hata : " + ex.Message);
                return false;
            }
        }

        //public static bool Rezervasyonİptal(int RezervasyonId)
        //{
        //    try
        //    {
        //        using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //        {
        //            if (baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();
        //            }
        //            string query = "Delete From Rezervasyonlar Where rezervasyon_id = @rezervasyonid";
        //            string query2 = "Update Faturalar Set rezervasyon_durum = 'İptal edilmiş rezervasyon' Where rezervasyon_id = @rezervasyonid";

        //            MySqlCommand komutSil = new MySqlCommand(query, baglanti);
        //            MySqlCommand komutGuncelle = new MySqlCommand(query2, baglanti);

        //            komutSil.Parameters.AddWithValue("@rezervasyonid", RezervasyonId);
        //            komutGuncelle.Parameters.AddWithValue("@rezervasyonid", RezervasyonId);


        //            int rowsAffected = komutSil.ExecuteNonQuery();
        //            int rowsAffected2 = komutGuncelle.ExecuteNonQuery();

        //            return rowsAffected > 0 && rowsAffected2 > 0 ;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Müşteri silme sırasında hata : " + ex.Message);
        //        return false;
        //    }
        //}

        public  bool MusteriGuncelle( string Musteriİsim, string MusteriSoyisim, string MusteriTelNo, string MusteriOdemeKart, int MusteriID)
        {
            try   
            {
                using(MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Update Musteriler Set musteri_isim = @musteriisim, musteri_soyisim= @musterisoyisim, musteri_tel_numarasi= @musteritelnumarasi, musteri_odeme_kart=@musteriodemekart Where musteri_id= @musteriid ";
                    using (MySqlCommand komut = new MySqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@musteriisim", Musteriİsim);
                        komut.Parameters.AddWithValue("@musterisoyisim", MusteriSoyisim);                        
                        komut.Parameters.AddWithValue("@musteritelnumarasi", MusteriTelNo);
                        komut.Parameters.AddWithValue("@musteriodemekart", MusteriOdemeKart);
                        komut.Parameters.AddWithValue("@musteriid", MusteriID);
                        int rowsAffected = komut.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public bool PersonelGuncelle(string Personelİsim, string PersonelSoyisim,  string PersonelPozisyon, string PersonelTelNumara, int PersonelID)
        {
            try 
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Update Personeller Set personel_isim = @personelisim, personel_soyisim= @personelsoyisim,  personel_pozisyon = @personelpozisyon, personel_tel_numarasi= @personeltelnumarasi Where personel_id= @personelid ";
                    using (MySqlCommand komut = new MySqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@personelisim", Personelİsim);
                        komut.Parameters.AddWithValue("@personelsoyisim", PersonelSoyisim);                        
                        komut.Parameters.AddWithValue("@personelpozisyon", PersonelPozisyon);
                        komut.Parameters.AddWithValue("@personeltelnumarasi", PersonelTelNumara);
                        komut.Parameters.AddWithValue("@personelid", PersonelID);

                        int rowsAffected = komut.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool OdaGuncelle(string OdaNumara, string OdaTur, string OdaFiyat,int OdaID)
        {
            try  
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Update Odalar Set  oda_tur= @odatur, oda_fiyat=@odafiyat   Where oda_id = @odaid ";
                    using (MySqlCommand komut = new MySqlCommand(query, baglanti))
                    {
                        //komut.Parameters.AddWithValue("@odanumarasi", OdaNumara);
                        komut.Parameters.AddWithValue("@odatur", OdaTur);
                        komut.Parameters.AddWithValue("@odafiyat", OdaFiyat);
                        komut.Parameters.AddWithValue("@odaid", OdaID);
                        int rowsAffected = komut.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public  static bool RezervasyonGoruntule(DataGridView rezervasyonListeGridview)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Select * From Rezervasyonlar";
                    DataTable veritablosu = new DataTable();
                    using (MySqlCommand komut14 = new MySqlCommand(query, baglanti))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut14))
                        {
                            dataAdapter.Fill(veritablosu);
                            rezervasyonListeGridview.DataSource = veritablosu;
                        }
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex.Message);
                return false;
            }
        }

        public static bool MusteriGoruntule(DataGridView musteriListeGridview)
        {
            
            try
            {
                using(MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Select * From Musteriler";
                    DataTable veritablosu = new DataTable();
                    using (MySqlCommand komut15 = new MySqlCommand(query, baglanti))
                    {
                        using (MySqlDataAdapter dataAdapter =  new MySqlDataAdapter(komut15))
                        {
                            dataAdapter.Fill(veritablosu);
                            musteriListeGridview.DataSource = veritablosu;
                        }
                        return true;
                    }
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show("HATA" + ex.Message);
                return false;
            }
           
            
            
           
        }

        public  static bool OdaGoruntule(DataGridView odaListeGridview)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Select * From Odalar";
                    DataTable veritablosu = new DataTable();
                    using (MySqlCommand komut16 = new MySqlCommand(query, baglanti))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut16))
                        {
                            dataAdapter.Fill(veritablosu);
                            odaListeGridview.DataSource = veritablosu;
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex.Message);
                return false;
            }
        }

        public  static bool PersonelGoruntule(DataGridView personelListeGridview)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Select * From Personeller";
                    DataTable veritablosu = new DataTable();
                    using (MySqlCommand komut17 = new MySqlCommand(query, baglanti))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut17))
                        {
                            dataAdapter.Fill(veritablosu);
                            personelListeGridview.DataSource = veritablosu;
                        }
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex.Message);
                return false;
            }
        }

        //public static decimal FaturaHesapla(DateTime GirisTarih, DateTime CikisTarih, int OdaId)
        //{
        //    using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //    {
        //        try
        //        {
        //            if (baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();
        //            }

        //            int gunSayisi = (CikisTarih.Date - GirisTarih.Date).Days +1 ;
                    
        //            string query =   "Select oda_fiyat From Odalar Where oda_id = @odaid";
        //            using (MySqlCommand komut19 = new MySqlCommand(query, baglanti))
        //            {
        //                komut19.Parameters.AddWithValue("@odaid", OdaId);
        //                object sonuc = komut19.ExecuteScalar();

        //                if(sonuc != null && sonuc != DBNull.Value)
        //                {
        //                    decimal gunlukFiyat = Convert.ToDecimal(sonuc);
        //                    decimal toplamFiyat = gunlukFiyat * gunSayisi;
        //                    return toplamFiyat;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Ücret hesaplanırken hata oluştu");
        //                    return 0;
        //                }
                            
        //            }
                    
        //        }catch (Exception ex)
        //        {
        //            MessageBox.Show ("HATA :" + ex.Message);
        //            return 0;
        //        }
                
        //    }
        //}

        //public static int SonRezervasyonIdGetir()
        //{
        //    using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //    {
        //        try
        //        {
        //            if (baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();
        //            }
        //            string query = "Select Last_Insert_Id()";
        //            using(MySqlCommand komut =  new MySqlCommand(query,baglanti))
        //            {
        //                return Convert.ToInt32(komut.ExecuteScalar());
        //            }
        //        }catch (Exception ex)
        //        {
        //            MessageBox.Show("HATA" +  ex.Message);
        //            return 0;
        //        }
        //    }
        //}
    
        public  static bool FaturaKayıtGoruntule( DataGridView FaturaListeGridview)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }

                    string query = "Update Faturalar Set rezervasyon_durum = 'Eski Rezervasyon' Where cikis_tarih <= @simdikiTarih";
                    MySqlCommand komutGuncelle = new MySqlCommand(query, baglanti);
                    komutGuncelle.Parameters.AddWithValue("@simdikiTarih", DateTime.Now);
                    int rowsAffected = komutGuncelle.ExecuteNonQuery();

                    string query2 = "Select * From Faturalar";
                    MySqlCommand komutListele = new MySqlCommand(query2, baglanti);
                    DataTable veriTablosu = new DataTable();
                    using (MySqlDataAdapter data = new MySqlDataAdapter(komutListele))
                    {
                        data.Fill(veriTablosu);
                        FaturaListeGridview.DataSource = veriTablosu;
                       
                    }
                    return rowsAffected > 0;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex.Message);
                return false;
            }
        }

        //public static bool FaturaKaydet( int Ücret, string Musteriİsim, string MusteriSoyisim, long MusteriKimlik, long MusteriTelNo, long MusteriOdemeKart, int RezervasyonId, int OdaNumarasi, DateTime GirisTarihi, DateTime CıkısTarihi)
        //{
        //    using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //    {
        //        try
        //        {
        //            if(baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();
        //            }
        //            string query = " Insert Into Faturalar ( ucret, musteri_isim, musteri_soyisim, musteri_kimlik_numarasi, musteri_tel_numarasi, musteri_odeme_kart, rezervasyon_id, oda_numarasi, giris_tarih, cikis_tarih) values ( @ucret, @musteriisim, @musterisoyisim, @musterikimliknumarasi, @musteritelnumarasi, @musteriodemekart, @rezervasyonid, @odanumarasi, @giristarih, @cikistarih)";
        //            using (MySqlCommand komut = new MySqlCommand(query, baglanti))
        //            {
                        
        //                komut.Parameters.AddWithValue("@ucret", Ücret);
        //                komut.Parameters.AddWithValue("@musteriisim", Musteriİsim);
        //                komut.Parameters.AddWithValue("@musterisoyisim", MusteriSoyisim);
        //                komut.Parameters.AddWithValue("@musterikimliknumarasi", MusteriKimlik);
        //                komut.Parameters.AddWithValue("@musteritelnumarasi", MusteriTelNo);
        //                komut.Parameters.AddWithValue("@musteriodemekart", MusteriOdemeKart);
        //                komut.Parameters.AddWithValue("@rezervasyonid", RezervasyonId);
        //                komut.Parameters.AddWithValue("@odanumarasi", OdaNumarasi);
        //                komut.Parameters.AddWithValue("@giristarih", GirisTarihi);
        //                komut.Parameters.AddWithValue("@cikistarih", CıkısTarihi);

        //                int rowsAffected = komut.ExecuteNonQuery();
        //                return rowsAffected > 0;
                        

        //            }                                           
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("HATA : " + ex.Message);
        //            return false;
        //        }
        //    }
        //}

        public static bool HesapAyarlarıGuncelle(string Yoneticiİsim, string YoneticiSoyisim, long YoneticiTelNumarasi, string YoneticiGuvenlikSoru, string YoneticiGuvenlikCevap, int YoneticiSifre)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir()) 
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                    

                string query = "Update Yoneticiler Set yonetici_isim= @yoneticiisim, yonetici_soyisim= @yoneticisoyisim, yonetici_tel_numarasi= @yoneticitelnumarasi, yonetici_guvenlik_soru= @yoneticiguvenliksoru, yonetici_guvenlik_cevap= @yoneticiguvenlikcevap, yonetici_sifre= @yoneticisifre  Where yonetici_id = @yoneticiid " ;
                using (MySqlCommand komut = new MySqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@yoneticiisim", Yoneticiİsim);
                    komut.Parameters.AddWithValue("@yoneticisoyisim", YoneticiSoyisim);
                    komut.Parameters.AddWithValue("@yoneticitelnumarasi", YoneticiTelNumarasi);
                    komut.Parameters.AddWithValue("@yoneticiguvenliksoru", YoneticiGuvenlikSoru);
                    komut.Parameters.AddWithValue("@yoneticiguvenlikcevap", YoneticiGuvenlikCevap);
                    komut.Parameters.AddWithValue("@yoneticisifre", YoneticiSifre);
                    komut.Parameters.AddWithValue("@yoneticiid", Giren_Yonetici_ID.GirisYapanYoneticiID);

                    return komut.ExecuteNonQuery() > 0;
                }
            }
        }
     
        public static bool YeniYoneticiKayıt(string Yoneticiİsim, string YoneticiSoyisim, string YoneticiKimlik, int YoneticiSifre, string YoneticiGuvenlikSoru, string YoneticiGuvenlikCevap, string YoneticiTelNumarasi)  
        {
            
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Insert Into Yoneticiler (yonetici_isim, yonetici_soyisim, yonetici_kimlik, yonetici_sifre, yonetici_guvenlik_soru, yonetici_guvenlik_cevap, yonetici_tel_numarasi) values (@yoneticiisim, @yoneticisoyisim, @yoneticikimlik, @yoneticisifre, @yoneticiguvenliksoru, @yoneticiguvenlikcevap, @yoneticitelnumarasi)";
                    using(MySqlCommand komut = new MySqlCommand( query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yoneticiisim", Yoneticiİsim);
                        komut.Parameters.AddWithValue("@yoneticisoyisim", YoneticiSoyisim);
                        komut.Parameters.AddWithValue("@yoneticikimlik", YoneticiKimlik);
                        komut.Parameters.AddWithValue("@yoneticisifre", YoneticiSifre);
                        komut.Parameters.AddWithValue("@yoneticiguvenliksoru", YoneticiGuvenlikSoru);
                        komut.Parameters.AddWithValue("@yoneticiguvenlikcevap", YoneticiGuvenlikCevap);
                        komut.Parameters.AddWithValue("@yoneticitelnumarasi", YoneticiTelNumarasi);
                        int rowsAffected = komut.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        //public static bool YoneticiKimlikKontrol(string YoneticiKimlik)
        //{
        //    try
        //    {
        //        using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
        //        {
        //            if (baglanti.State != ConnectionState.Open)
        //            {
        //                baglanti.Open();

        //            }
        //            string query = "Select Count(*) From Yoneticiler Where yonetici_kimlik_numarasi = @yoneticikimliknumarasi";
        //            MySqlCommand komut = new MySqlCommand(query, baglanti);
        //            komut.Parameters.AddWithValue("@musterikimliknumarasi", YoneticiKimlik);
        //            int kayitKontrol = Convert.ToInt32(komut.ExecuteScalar());
        //            return kayitKontrol > 0;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public string GuvenlikSorusuGetir(string YoneticiKimlik)
        {
            try
            {
                using(MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Select yonetici_guvenlik_soru From Yoneticiler Where yonetici_kimlik = @yoneticikimlik";
                    using(MySqlCommand komut = new MySqlCommand( query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yoneticikimlik", YoneticiKimlik);
                        object islem = komut.ExecuteScalar();
                        return islem != null ? islem.ToString() : "";
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception("Güvenlik sorusunda hata oluştu: " + ex.Message);
            }
        }

        public bool GuvenlikCevapKontrol (string YoneticiKimlik, string YoneticiGuvenlikCevap)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = " Select Count(*) From Yoneticiler Where yonetici_kimlik = @yoneticikimlik and yonetici_guvenlik_cevap = @yoneticiguvenlikcevap";
                    using (MySqlCommand komut = new MySqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yoneticikimlik", YoneticiKimlik);
                        komut.Parameters.AddWithValue("@yoneticiguvenlikcevap", YoneticiGuvenlikCevap);
                        int islem = Convert.ToInt32(komut.ExecuteScalar());
                        return islem  > 0;
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception("Güvenlik cevabında hata oluştu: " + ex.Message);

            }
        }
        
        public bool GuvenlikSifreGuncelle (string YoneticiKimlik , string YoneticiSifre)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Update Yoneticiler Set yonetici_sifre = @yoneticisifre Where yonetici_kimlik = @yoneticikimlik";
                    using (MySqlCommand komut = new MySqlCommand (query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yoneticikimlik", YoneticiKimlik);
                        komut.Parameters.AddWithValue("@yoneticisifre", YoneticiSifre);
                        
                        int rowsAffected = komut.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static (string Yoneticiİsim, string YoneticiSoyisim, string YoneticiKimlik, string YoneticiTelNumarasi) YoneticiBilgiGetir(int YoneticiID)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }


                    string query = "Select yonetici_isim, yonetici_soyisim, yonetici_kimlik, yonetici_tel_numarasi From Yoneticiler Where yonetici_id = @yoneticiid";
                    using (MySqlCommand komut = new MySqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@yoneticiid", YoneticiID);



                        using (MySqlDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return (reader["yonetici_isim"].ToString(), reader["yonetici_soyisim"].ToString(), reader["yonetici_kimlik"].ToString(), reader["yonetici_tel_numarasi"].ToString());
                            }

                            return (null, null, null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
        }

        public DataTable BoşOdalarıGetir(DateTime GirisTarih, DateTime CikisTarih)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "Select oda_id As odaid , oda_numarasi As odanumarasi , oda_tur As odatur , oda_fiyat As odafiyat , oda_durum As odadurum From Odalar Where oda_durum = 'Boş' And oda_id Not In (Select oda_id From Rezervasyonlar Where (@baslangic <= cikis_tarih And @bitis >= giris_tarih))";

                    MySqlCommand komut = new MySqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@baslangic", GirisTarih);
                    komut.Parameters.AddWithValue("@bitis", CikisTarih);
                    DataTable veritablosu = new DataTable();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                    dataAdapter.Fill(veritablosu);
                    return veritablosu;
                }
                catch (Exception ex)
                {
                    throw new Exception("Boş odalar getirilirken hata : " + ex.Message);

                }
            }
        }

        public DataTable MusaitOdalarıGetir ( DateTime GirisTarih, DateTime CikisTarih)
        {
            var veriTablosu = new DataTable();
            using(var baglanti = BaglantiAc.baglantiGetir())
            {
                if(baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                string query = "Select oda_id As odaid , oda_numarasi As odanumarasi , oda_tur As odatur , oda_fiyat As odafiyat , 'Boş' As 'oda_durum' From Odalar Where oda_id Not In ( Select Distinct oda_id From Rezervasyonlar Where (@giris_tarih Between giris_tarih And cikis_tarih) Or (@cikis_tarih Between giris_tarih And cikis_tarih) Or (giris_tarih Between @giris_tarih And @cikis_tarih )) Order By oda_numarasi";
                using(var komut = new MySqlDataAdapter(query, baglanti))
                {
                    komut.SelectCommand.Parameters.AddWithValue("@giris_tarih", GirisTarih);
                    komut.SelectCommand.Parameters.AddWithValue("@cikis_tarih", CikisTarih);
                    komut.Fill(veriTablosu);
                }
            }
            return veriTablosu;
        }
      
        public static (bool Basarili, int RezervasyonId) RezervasyonYap (int OdaId, int MusteriId, DateTime GirisTarih, DateTime CikisTarih, long MusteriKimlik, long MusteriTel , long MusteriKart, string Musteriİsim, string MusteriSoyisim, int OdaNumarasi, decimal OdaFiyat)
        {
            using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                using (MySqlTransaction transaction = baglanti.BeginTransaction())
                {
                    try
                    {
                        int rezervasyonId = 0;
                        string rezervasyonQuery = "Insert Into Rezervasyonlar (oda_id , musteri_id, giris_tarih, cikis_tarih, musteri_kimlik_numarasi, musteri_isim, musteri_soyisim, oda_numarasi) Values (@odaid, @musteriid, @giristarih, @cikistarih, @musterikimliknumarasi, @musteriisim, @musterisoyisim, @odanumarasi); Select Last_Insert_ID();"; 
                        using (MySqlCommand rezervasyonKomut = new MySqlCommand(rezervasyonQuery, baglanti, transaction))
                        {
                            rezervasyonKomut.Parameters.AddWithValue("@odaid", OdaId);
                            rezervasyonKomut.Parameters.AddWithValue("@musteriid", MusteriId);
                            rezervasyonKomut.Parameters.AddWithValue("@giristarih", GirisTarih);
                            rezervasyonKomut.Parameters.AddWithValue("@cikistarih", CikisTarih);
                            rezervasyonKomut.Parameters.AddWithValue("@musterikimliknumarasi", MusteriKimlik);
                            rezervasyonKomut.Parameters.AddWithValue("@musteriisim", Musteriİsim);
                            rezervasyonKomut.Parameters.AddWithValue("@musterisoyisim", MusteriSoyisim);
                            rezervasyonKomut.Parameters.AddWithValue("@odanumarasi", OdaNumarasi);

                            rezervasyonId = Convert.ToInt32(rezervasyonKomut.ExecuteScalar());
                            if (rezervasyonId <= 0) 
                            {
                                transaction.Rollback();
                                return (false,0);
                            }
                        }
                        string odaQuery = "Update Odalar Set oda_durum = 'Dolu' Where oda_id = @odaid";
                        using (MySqlCommand odaKomut = new MySqlCommand(odaQuery, baglanti, transaction))
                        {
                            odaKomut.Parameters.AddWithValue("@odaid", OdaId);
                            if(odaKomut.ExecuteNonQuery() <= 0)
                            {
                                transaction.Rollback();
                                return (false, rezervasyonId);
                            }
                        }
                        int gunSayisi = (CikisTarih - GirisTarih).Days ;
                        decimal toplamTutar = gunSayisi * OdaFiyat;
                        string faturaQuery = "Insert Into Faturalar (ucret, musteri_isim, musteri_soyisim, musteri_kimlik_numarasi, musteri_tel_numarasi, musteri_odeme_kart, rezervasyon_id, oda_numarasi, giris_tarih, cikis_tarih) values ( @ucret, @musteriisim, @musterisoyisim, @musterikimliknumarasi, @musteritelnumarasi, @musteriodemekart, @rezervasyonid, @odanumarasi, @giristarih, @cikistarih)";
                        using(MySqlCommand faturaKomut = new MySqlCommand(faturaQuery, baglanti, transaction))
                        {
                            faturaKomut.Parameters.AddWithValue("@ucret", toplamTutar);
                            faturaKomut.Parameters.AddWithValue("@musteriisim", Musteriİsim);
                            faturaKomut.Parameters.AddWithValue("@musterisoyisim", MusteriSoyisim);
                            faturaKomut.Parameters.AddWithValue("@musterikimliknumarasi", MusteriKimlik);
                            faturaKomut.Parameters.AddWithValue("@musteritelnumarasi", MusteriTel);
                            faturaKomut.Parameters.AddWithValue("@musteriodemekart", MusteriKart);
                            faturaKomut.Parameters.AddWithValue("@odanumarasi", OdaNumarasi);
                            faturaKomut.Parameters.AddWithValue("@giristarih", GirisTarih);
                            faturaKomut.Parameters.AddWithValue("@cikistarih", CikisTarih);
                            faturaKomut.Parameters.AddWithValue("@rezervasyonid", rezervasyonId);

                            if (faturaKomut.ExecuteNonQuery() <= 0)
                            {
                                transaction.Rollback();
                                return (false, rezervasyonId);
                            }
                        }
                        transaction.Commit();
                        return (true, rezervasyonId);
                    }
                    catch (Exception )
                    {
                        transaction.Rollback();
                        return (false, 0);
                    }
                }
            }
        }
        public static bool Rezervasyonİptal(int RezervasyonID)
        {
            try
            {
                using (MySqlConnection baglanti = BaglantiAc.baglantiGetir())
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    using(MySqlTransaction transaction = baglanti.BeginTransaction())
                    {
                        try
                        {
                            string odaIDQQuery= "SELECT oda_id FROM Rezervasyonlar WHERE rezervasyon_id = @rezervasyonid";
                            int odaID;
                            using (MySqlCommand odaIDKomut = new MySqlCommand(odaIDQQuery, baglanti, transaction))
                            {
                                odaIDKomut.Parameters.AddWithValue("@rezervasyonid", RezervasyonID);
                                object sonuc = odaIDKomut.ExecuteScalar();
                                if(sonuc == null)
                                {
                                    throw new Exception("Rezervasyon bulunamadı");
                                }
                                odaID = Convert.ToInt32(sonuc);
                            }
                            string rezervasyonSilQuery = "Delete From Rezervasyonlar Where rezervasyon_id = @rezervasyonid";
                            using (MySqlCommand komutSil = new MySqlCommand(rezervasyonSilQuery, baglanti, transaction))
                            {
                                komutSil.Parameters.AddWithValue("@rezervasyonid", RezervasyonID);
                                int rowsAffected = komutSil.ExecuteNonQuery();
                                if(rowsAffected <= 0)
                                {
                                    throw new Exception("Rezervasyon silinemedi");
                                }
                            }
                            string faturaQuery = "Update Faturalar Set rezervasyon_durum = 'İptal edilmiş rezervasyon' Where rezervasyon_id = @rezervasyonid";
                            using (MySqlCommand komutGuncelle = new MySqlCommand (faturaQuery, baglanti, transaction))
                            {
                                komutGuncelle.Parameters.AddWithValue("@rezervasyonid", RezervasyonID);
                                int rowsAffected2 = komutGuncelle.ExecuteNonQuery();
                                if(rowsAffected2 <= 0)
                                {
                                    MessageBox.Show("Fatura güncellenemedi veya bulunamadı");
                                }
                            }
                            string odaQuery = "Update Odalar Set oda_durum = 'Boş' Where oda_id = @odaid";
                            using (MySqlCommand odaKomut = new MySqlCommand(odaQuery, baglanti, transaction))
                            {
                                odaKomut.Parameters.AddWithValue("@odaid", odaID);
                                int rowsAffected3 = odaKomut.ExecuteNonQuery();
                                if(rowsAffected3 <= 0)
                                {
                                    throw new Exception("Oda durum güncellenemedi");
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Rezervasyon başarıyla iptal edildi ve oda durumu güncellendi");
                            return true;
                        }
                        catch (Exception ex) 
                        {
                            transaction.Rollback();
                            throw new Exception("İşlem sırasında hata : " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezerasyon iptal sırasında hata : " + ex.Message);
                return false;
            }

        }

        public int MusteriSayisiniGetir()
        {
            using (var baglanti = BaglantiAc.baglantiGetir())
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                string query = "SELECT COUNT(*) FROM Musteriler";
                using (var komut = new MySqlCommand(query, baglanti))
                {
                    return Convert.ToInt32(komut.ExecuteScalar());
                }
            }
        }

        public int OdaSayisiniGetir()
        {
            using (var baglanti = BaglantiAc.baglantiGetir())
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                string query = "SELECT COUNT(*) FROM Odalar";
                using (var komut = new MySqlCommand(query, baglanti))
                {
                    return Convert.ToInt32(komut.ExecuteScalar());
                }
            }
        }

        public int PersonelSayisiniGetir()
        {
            using (var baglanti = BaglantiAc.baglantiGetir())
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                string query = "SELECT COUNT(*) FROM Personeller";
                using (var komut = new MySqlCommand(query, baglanti))
                {
                    return Convert.ToInt32(komut.ExecuteScalar());
                }
            }
        }

        public int RezervasyonSayisiGetir()
        {
            using(var baglanti = BaglantiAc.baglantiGetir())
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();
                    string query = "Select Count(*) From Rezervasyonlar r Inner Join Faturalar f On r.rezervasyon_id = f.rezervasyon_id Where f.rezervasyon_durum = @rezervasyondurum";
                    using (var komut = new MySqlCommand(query, baglanti))
                    {
                        komut.Parameters.AddWithValue("@rezervasyondurum", "Aktif Rezervasyon");
                        return Convert.ToInt32(komut.ExecuteScalar());
                    }
                }catch(Exception ex)
                {
                    throw new Exception("Aktif rezervasyon sayısı alınırken hata: " + ex.Message);
                }
            }
        }
        

    }
}
