using MySql.Data.MySqlClient;
using OtelYönetimProjesi.Data_Access_Layer;
using OtelYönetimProjesi.Entity_Layer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYönetimProjesi.Business_Layer
{
    public class Yonetici_Bussiness_Layer
    {
        private static Yonetici_DAL Yonetici_Dal = new Yonetici_DAL();

        public Yonetici_Bussiness_Layer()
        {
            //Yonetici_Dal = new Yonetici_DAL();
        }

        public static (bool basarili, string mesaj) YoneticiGirisBLL(string YoneticiKimlik, string YoneticiSifre)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(YoneticiKimlik))
                {
                    return (false, "Kimlik numarası boş bırakılamaz");
                }

                if (string.IsNullOrWhiteSpace(YoneticiSifre))
                {
                    return (false, "Şifre boş bırakılamaz");
                }

                
                if (YoneticiKimlik.Length != 11 || !YoneticiKimlik.All(char.IsDigit))
                {
                    return (false, "Kimlik numarası 11 haneli sayısal değer olmalıdır");
                }

                
                if (YoneticiSifre.Length < 6)
                {
                    return (false, "Şifre en az 6 karakter olmalıdır");
                }

                
                bool girisBasarili = Yonetici_DAL.YoneticiGiris(YoneticiKimlik, YoneticiSifre);

                if (girisBasarili)
                {
                    return (true, "Hoşgeldiniz : " + Giren_Yonetici_ID.Yonetici_Isim);
                }
                else
                {
                    return (false, "Kimlik numarası veya şifre hatalı");
                }
            }
            catch (Exception ex)
            {
                 
                return (false, $"Giriş işlemi sırasında bir hata oluştu: {ex.Message}");
            }
        }
     
        public static (bool basarili, string mesaj) MusteriKaydetBLL (string Musteriİsim, string MusteriSoyisim, string MusteriKimlik, string MusteriTelNo, string MusteriOdemeKart)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(MusteriKimlik) ||
                    string.IsNullOrWhiteSpace(Musteriİsim) ||
                    string.IsNullOrWhiteSpace(MusteriSoyisim) ||
                    string.IsNullOrWhiteSpace(MusteriTelNo) ||
                    string.IsNullOrWhiteSpace(MusteriOdemeKart))
                {
                    return (false, "Lütfen tüm alanları doldurunuz");
                }

                
                if (MusteriKimlik.Length != 11 || !MusteriKimlik.All(char.IsDigit))
                {
                    return (false, "Kimlik numarası 11 haneli olmalıdır");
                }

                if (Yonetici_DAL.MusteriKimlikKontrol(MusteriKimlik))
                {
                    return (false, "Bu kimlik numarası sistemde mevcut");
                }
                
                string dogruTelNo = new string(MusteriTelNo.Where(char.IsDigit).ToArray());
                if (dogruTelNo.Length != 10)
                {
                    return (false, "Telefon numarası 10 haneli olmalıdır");
                }

                
                string dogruKartNo = new string(MusteriOdemeKart.Where(char.IsDigit).ToArray());
                if (dogruKartNo.Length != 16)
                {
                    return (false, "Kart numarası 16 haneli olmalıdır");
                }

                
                bool kayitBasarili = Yonetici_DAL.MusteriKaydet(MusteriKimlik, Musteriİsim.Trim(), MusteriSoyisim.Trim(), dogruTelNo, dogruKartNo);

                if (kayitBasarili)
                {
                    return (true, "Müşteri sisteme başarıyla kaydedildi");
                }
                else
                {
                    return (false, "Kayıt sırasında bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                return (false, "Bir hata oluştu: " + ex.Message);
            }
        }
    
        public static (bool basarili, string mesaj) PersonelKaydetBLL (string Personelİsim, string PersonelSoyisim, string PersonelKimlik, string PersonelPozisyon, string PersonelTelNumara)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(Personelİsim) ||
                    string.IsNullOrWhiteSpace(PersonelSoyisim) ||
                    string.IsNullOrWhiteSpace(PersonelKimlik) ||
                    string.IsNullOrWhiteSpace(PersonelPozisyon) ||
                    string.IsNullOrWhiteSpace(PersonelTelNumara))
                {
                    return (false, "Lütfen tüm alanları doldurunuz");
                }

                
                if (PersonelKimlik.Length != 11 || !PersonelKimlik.All(char.IsDigit))
                {
                    return (false, "Kimlik numarası 11 haneli olmalıdır");
                }

                
                if (Yonetici_DAL.PersonelKimlikKontrol(PersonelKimlik))
                {
                    return (false, "Bu kimlik numarası sistemde mevcut");
                }

                
                string temizTelNo = new string(PersonelTelNumara.Where(char.IsDigit).ToArray());
                if (temizTelNo.Length != 10)
                {
                    return (false, "Telefon numarası 10 haneli olmalıdır");
                }

                
                bool kayitBasarili = Yonetici_DAL.PersonelKaydet(
                    Personelİsim.Trim(),
                    PersonelSoyisim.Trim(),
                    PersonelKimlik,
                    PersonelPozisyon.Trim(),
                    temizTelNo
                );

                if (kayitBasarili)
                {
                    return (true, "Personel sisteme başarıyla kaydedildi");
                }
                else
                {
                    return (false, "Kayıt sırasında bir hata oluştu");
                }
            }
            catch (Exception ex)
            {
                return (false, "Bir hata oluştu: " + ex.Message);
            }

        }

        public static (bool basarili, string mesaj) OdaKaydetBLL (string OdaNumara, string OdaTur, string OdaFiyat)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(OdaNumara) ||
                    string.IsNullOrWhiteSpace(OdaTur) ||
                    string.IsNullOrWhiteSpace(OdaFiyat))
                {
                    return (false, "Lütfen tüm alanları doldurunuz");
                }

                
                if (!OdaNumara.All(char.IsDigit))
                {
                    return (false, "Oda numarası sadece rakamlardan oluşmalıdır");
                }

                
                if (!decimal.TryParse(OdaFiyat, out decimal fiyat) || fiyat <= 0)
                {
                    return (false, "Geçerli bir fiyat giriniz");
                }

                
                if (Yonetici_DAL.OdaNumaraKontrol(OdaNumara))
                {
                    return (false, "Bu oda numarası zaten kayıtlı");
                }

                
                bool kayitBasarili = Yonetici_DAL.OdaKaydet(OdaNumara, OdaTur, OdaFiyat);

                if (kayitBasarili)
                {
                    return (true, "Oda başarıyla kaydedildi");
                }
                else
                {
                    return (false, "Kayıt sırasında bir hata oluştu");
                }
            }
            catch (Exception ex)
            {
                return (false, "Bir hata oluştu: " + ex.Message);
            }
        }
        
        public static bool MusteriSilBLL (int MusteriId)
        {
            try
            {
                if (MusteriId <= 0)
                {
                    MessageBox.Show("Geçerli bir müşteri seçiniz!");
                    return false;
                }

                return Yonetici_DAL.MusteriSil(MusteriId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }

        public static bool PersonelSilBLL(int PersonelId)
        {
            try
            {
                
                if (PersonelId <= 0)
                {
                    throw new Exception("Geçersiz personel ID.");
                }

                
                Yonetici_DAL personelDAL = new Yonetici_DAL();
                return Yonetici_DAL.PersonelSil(PersonelId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel silme işlemi başarısız: " + ex.Message);
                return false;
            }
        }
         
        public static bool OdaSilBLL(int OdaId)
        {
            try
            {
                
                if (OdaId <= 0)
                {
                    throw new Exception("Geçersiz oda ID.");
                }

                
                Yonetici_DAL odaDAL = new Yonetici_DAL();
                return Yonetici_DAL.OdaSil(OdaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda silme işlemi başarısız: " + ex.Message);
                return false;
            }
        }

        public static (bool basarili, string mesaj) MusteriGuncelleBLL (string Musteriİsim, string MusteriSoyisim,  string MusteriTelNo, string MusteriOdemeKart, int MusteriID)
        {
            try
            {
                
                if (string.IsNullOrEmpty(Musteriİsim) || string.IsNullOrEmpty(MusteriSoyisim) || string.IsNullOrEmpty(MusteriTelNo) || string.IsNullOrEmpty(MusteriOdemeKart))

                {
                    return (false, "Lütfen tüm alanları doldurunuz!");
                }

                
                if (MusteriTelNo.Length != 10)
                {
                    return (false, "Telefon numarası 10 haneli olmalıdır!");
                }

                if (MusteriOdemeKart.Length != 16)
                {
                    return (false, "Kart numarası 16 haneli olmalıdır!");
                }

                
                bool sonuc = new Yonetici_DAL().MusteriGuncelle( Musteriİsim,
                    MusteriSoyisim, MusteriTelNo, MusteriOdemeKart,MusteriID);

                if (sonuc)
                {
                    return (true, "Güncelleme başarılı!");
                }
                else
                {
                    return (false, "Güncelleme başarısız!");
                }
            }
            catch (Exception ex)
            {
                return (false, "Hata oluştu: " + ex.Message);
            }
        }

        public static (bool basarili, string mesaj) PersonelGuncelleBLL (string Personelİsim, string PersonelSoyisim, string PersonelTelNo, string PersonelPozisyon, int PersonelID)
        {
            try
            {
                
                if (string.IsNullOrEmpty(Personelİsim) || string.IsNullOrEmpty(PersonelSoyisim) ||
                     string.IsNullOrEmpty(PersonelPozisyon) ||
                    string.IsNullOrEmpty(PersonelTelNo))
                {
                    return (false, "Lütfen tüm alanları doldurunuz!");
                }

                
                if (PersonelTelNo.Length != 10 || !PersonelTelNo.All(char.IsDigit))
                {
                    return (false, "Telefon numarası 10 haneli olmalı ve sadece rakam içermelidir!");
                }

                
                bool sonuc = new Yonetici_DAL().PersonelGuncelle(Personelİsim, PersonelSoyisim,
                     PersonelPozisyon, PersonelTelNo, PersonelID);

                if (sonuc)
                {
                    return (true, "Personel bilgileri başarıyla güncellendi.");
                }
                else
                {
                    return (false, "Güncelleme işlemi başarısız oldu!");
                }
            }
            catch (Exception ex)
            {
                return (false, "Hata oluştu: " + ex.Message);
            }
        }

        public static (bool basarili, string mesaj) OdaGuncelleBLL (string OdaNumara, string OdaTur, string OdaFiyat, int OdaID)
        {
            try
            {
                
                if ( string.IsNullOrEmpty(OdaTur) ||
                    string.IsNullOrEmpty(OdaFiyat))
                {
                    return (false, "Lütfen tüm alanları doldurunuz!");
                }

                
                if (!decimal.TryParse(OdaFiyat, out decimal fiyat))
                {
                    return (false, "Oda fiyatı sayısal bir değer olmalıdır!");
                }

                //if (!int.TryParse(OdaNumara, out int odaNo))
                //{
                //    return (false, "Oda numarası sayısal bir değer olmalıdır!");
                //}

                
                if (Yonetici_DAL.OdaNumaraKontrol(OdaNumara))
                {
                    return (false, "Bu oda numarası sistemde zaten kayıtlı!");
                }

                
                bool sonuc = Yonetici_DAL.OdaGuncelle(OdaNumara, OdaTur, OdaFiyat,OdaID);

                if (sonuc)
                {
                    return (true, "Oda bilgileri başarıyla güncellendi.");
                }
                else
                {
                    return (false, "Güncelleme işlemi başarısız oldu!");
                }
            }
            catch (Exception ex)
            {
                return (false, "Hata oluştu: " + ex.Message);
            }
        }

        public static (bool basarili, string mesaj) HesapAyarlariGuncelleBLL (string Yoneticiİsim, string YoneticiSoyisim, string YoneticiTelNumara, string YoneticiGuvenlikSoru, string YoneticiGuvenlikCevap, string YoneticiSifre, string YoneticiSifreTekrar)
        {
           
            try
            {
                if (string.IsNullOrEmpty(Yoneticiİsim)|| string.IsNullOrEmpty(YoneticiSoyisim) || string.IsNullOrEmpty(YoneticiTelNumara) || string.IsNullOrEmpty(YoneticiGuvenlikSoru) || string.IsNullOrEmpty(YoneticiGuvenlikCevap)|| string.IsNullOrEmpty(YoneticiSifre)|| string.IsNullOrEmpty(YoneticiSifreTekrar))
                {
                    return (false, "Lütfen tüm alanları doldurun");
                }

                if (YoneticiSifre.Length < 6)
                {
                    return (false, "Şifreniz en az 6 karakterli olmalıdır");
                }

                if (YoneticiSifre != YoneticiSifreTekrar)
                {
                    return (false, "Şifreler eşleşmiyor ");
                }

                if (!int.TryParse(YoneticiSifre, out int sifreInt))
                {
                    return (false, "Şifreniz sadece sayılardan oluşmalı");
                }

                if(!long.TryParse(YoneticiTelNumara, out long telNumara))
                {
                    return (false, " Geçersiz telefon numarası");
                }

                bool islem = Yonetici_DAL.HesapAyarlarıGuncelle(Yoneticiİsim, YoneticiSoyisim, long.Parse(YoneticiTelNumara), YoneticiGuvenlikSoru, YoneticiGuvenlikCevap, sifreInt );
                if (islem)
                {
                    return (true, "Hesap bilgileri başarıyla güncellendi");
                }
                else
                {
                    return (false, "Hesap bilgileri güncellenemedi");
                }

            }
            catch (Exception ex)
            {
                return (false,"Hata oluştu:" +  ex.Message);
            }
             
                
        }
        
        public static (bool basarili, string) YeniYoneticiKayitBLL (string Yoneticiİsim, string YoneticiSoyisim, string YoneticiKimlik, int YoneticiSifre, int YoneticiSifreTekrar, string YoneticiGuvenlikSoru, string YoneticiGuvenlikCevap, string YoneticiTelNumarasi)
        {
            if (YoneticiSifre != YoneticiSifreTekrar)
            {
                return (false, "Şifreler eşleşmiyor");
            }

            if (string.IsNullOrEmpty(Yoneticiİsim) || string.IsNullOrEmpty(YoneticiSoyisim) || string.IsNullOrEmpty(YoneticiGuvenlikSoru) || string.IsNullOrEmpty(YoneticiGuvenlikCevap))
            {
                return (false, "Lütfen tüm alanları doldurunuz");
            }

            if(YoneticiKimlik.Length != 11 || !YoneticiKimlik.All(char.IsDigit))
            {
                return (false, "Bu kimlik numarası sistemde mevcut");
            }

            string dogruTelNo = new string(YoneticiTelNumarasi.Where(char.IsDigit).ToArray());
            if (dogruTelNo.Length != 10)
            {
                return (false, "Telefon numarası 10 haneli olmalıdır");
            }

            if (Yonetici_DAL.MusteriKimlikKontrol(YoneticiKimlik))
            {
                return (false, "Bu kimlik numarası sistemde mevcut");
            }


            bool sonuc = Yonetici_DAL.YeniYoneticiKayıt(Yoneticiİsim, YoneticiSoyisim, YoneticiKimlik, YoneticiSifre, YoneticiGuvenlikSoru, YoneticiGuvenlikCevap, YoneticiTelNumarasi);

            if (sonuc)
            {
                return (true, "Yönetici başarıyla kaydedildi.");
            }
            else
            {
                return (false, "Yönetici kaydı başarısız oldu.");
            }
        }
              
        public string GuvenlikSorusuGetirBLL (string YoneticiKimlik)
        {
            if (string.IsNullOrWhiteSpace(YoneticiKimlik))
            {
                throw new ArgumentException("Yönetici kimlik numarası boş olamaz.");
            }

            return Yonetici_Dal.GuvenlikSorusuGetir(YoneticiKimlik);
        }

        public bool GuvenlikCevapKontrolBLL (string YoneticiKimlik, string YoneticiGuvenlikCevap)
        {
            if (string.IsNullOrWhiteSpace(YoneticiKimlik))
            {
                throw new ArgumentException("Yönetici kimlik numarası boş olamaz.");
            }

            if (string.IsNullOrWhiteSpace(YoneticiGuvenlikCevap))
            {
                throw new ArgumentException("Güvenlik sorusu cevabı boş olamaz.");
            }
            return Yonetici_Dal.GuvenlikCevapKontrol(YoneticiKimlik, YoneticiGuvenlikCevap);
        }

        public bool GuvenlikSifreGuncelleBLL(string YoneticiKimlik, string YoneticiSifre, string YoneticiSifreTekrar)
        {
            if (string.IsNullOrWhiteSpace(YoneticiKimlik))
            {
                throw new ArgumentException("Yönetici kimlik numarası boş olamaz");
            }

            if (string.IsNullOrWhiteSpace(YoneticiSifre))
            {
                throw new ArgumentException("Yeni şifre boş olamaz");
            }

            if (YoneticiSifre != YoneticiSifreTekrar)
            {
                throw new ArgumentException("Şifreler eşleşmiyor");
            }

            if (YoneticiSifre.Length < 6)
            {
                throw new ArgumentException("Şifre en az 6 karakter olmalıdır");
            }

            return Yonetici_Dal.GuvenlikSifreGuncelle(YoneticiKimlik, YoneticiSifre);
        }

        public DataTable BosOdalarıGetirBLL(DateTime GirisTarih, DateTime CikisTarih)
        {
            
            if (GirisTarih >= CikisTarih)
            {
                throw new Exception("Başlangıç tarihi, bitiş tarihinden büyük olamaz!");
            }

            if (GirisTarih < DateTime.Now.Date)
            {
                throw new Exception("Geçmiş tarih için sorgulama yapılamaz!");
            }
            
            return Yonetici_Dal.BoşOdalarıGetir(GirisTarih, CikisTarih);
        }

        public DataTable MusaitOdalarıGetirBLL(DateTime GirisTarih, DateTime CikisTarih)
        {
            if(GirisTarih >= CikisTarih)
            {
                throw new Exception("Giriş tarihi, çıkış tarihinden sonra olamaz");
            }
            if (GirisTarih < DateTime.Now)
            {
                throw new Exception("Geçmiş tarih için rezervasyon yapılamaz");
            }
            if((CikisTarih - GirisTarih).TotalDays > 30)
            {
                throw new Exception("30 günü aşan bi tarih için rezervasyon yapılamaz");
            }
            return Yonetici_Dal.MusaitOdalarıGetir(GirisTarih,CikisTarih);
        }

        public static (bool Basarili, string Mesaj, decimal? Tutar) RezervasyonYapBLL(int OdaId, int MusteriId, DateTime GirisTarih, DateTime CikisTarih, long MusteriKimlik, long MusteriTel, long MusteriKart, string Musteriİsim, string MusteriSoyisim, int OdaNumarasi, decimal OdaFiyat)
        {
            try
            {
                if (GirisTarih >= CikisTarih)
                {
                    return (false, "Giriş tarihi, çıkış tarihinden sonra olamaz", null);
                }
                if (GirisTarih < DateTime.Now.Date)
                {
                    return (false, "Geçmiş tarihli rezervasyon yapılamaz", null);
                }
                int gunSayisi = (CikisTarih - GirisTarih).Days + 1;
                if (gunSayisi <= 0)
                {
                    return (false, "En az bir gün rezervasyon yapınız", null);
                }
                DataTable odalar = Yonetici_Dal.BoşOdalarıGetir(GirisTarih, CikisTarih);
                var oda = odalar.AsEnumerable().FirstOrDefault(row => Convert.ToInt32(row["odaid"]) == OdaId);
                if(oda == null)
                {
                    return (false, "Seçilen oda istenilen tarihler arasında dolu", null);
                }
                //decimal odaFiyat = Convert.ToDecimal(oda["odafiyat"]);
                decimal toplamTutar = gunSayisi * OdaFiyat;

                var islem = Yonetici_DAL.RezervasyonYap(OdaId, MusteriId, GirisTarih, CikisTarih, MusteriKimlik, MusteriTel, MusteriKart, Musteriİsim, MusteriSoyisim, OdaNumarasi, OdaFiyat);
                if (!islem.Basarili)
                {
                    return (false, "Rezervasyon işlemi başarısız", null);
                }
                return (true, "Rezervasyon başarıyla oluşturuldu", null);

            }
            catch (Exception ex)
            {
                return (false, "Rezervasyon işlemi sırasında hata" + ex.Message, null);
            }
        }

        public int RezervasyonSayisiGetirBLL()
        {
            try
            {
                return Yonetici_Dal.RezervasyonSayisiGetir();
            }catch (Exception ex)
            {
                throw new Exception("İşlem sırasında hata: " + ex.Message);
            }
        }

        public int MusteriSayisiGetirBLL()
        {
            try
            {
                return Yonetici_Dal.MusteriSayisiniGetir();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int OdaSayisiGetirBLL()
        {
            try
            {
                return Yonetici_Dal.OdaSayisiniGetir();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int PersonelSayisiGetirBLL()
        {
            try
            {
                return Yonetici_Dal.PersonelSayisiniGetir();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool NotYazBLL(string notMetin, string yoneticiIsim, string yoneticiSoyisim)
        {
            if (string.IsNullOrEmpty(notMetin))
                throw new Exception("Not metni boş olamaz!");

            Not_Entity_Layer not = new Not_Entity_Layer
            {
                Not_Metin = notMetin,
                Yonetici_Isim = yoneticiIsim,
                Yonetici_Soyisim = yoneticiSoyisim
            };
            return Yonetici_Dal.NotYaz(not);
        }

        public List <Not_Entity_Layer> NotGetirBLL()
        {
            return Yonetici_Dal.NotGetir();
        }

    }
}
