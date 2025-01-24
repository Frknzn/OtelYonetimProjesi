# OtelYonetimProjesi
 # Otel Yönetim Sistemi
## Proje Hakkında
Bu proje, otel personeli ve yöneticiler için günlük operasyonları kolaylaştırmayı hedefleyen bir otel yönetim sistemidir.
## Özellikler
### Yöneticiler
Yönetici Bilgileri
ID: Yöneticinin benzersiz kimliği
İsim ve Soyisim
Kimlik Numarası
Telefon Numarası
Şifre, Güvenlik Sorusu ve Cevabı
Fonksiyonlar
Müşteri, personel, oda, rezervasyon ve fatura bilgilerini düzenleme ve görüntüleme
*Yeni yöneticiler ekleme
### Personel
Personel Bilgileri
ID: Personelin benzersiz kimliği
İsim ve Soyisim
Kimlik ve Telefon Numarası
Pozisyon
Fonksiyonlar
*Personel ekleme, silme ve güncelleme
### Odalar
Oda Bilgileri
ID: Odanın benzersiz kimliği
Numara, Tür, Fiyat ve Durum
Fonksiyonlar
*Oda ekleme, silme ve güncelleme
### Müşteriler
Müşteri Bilgileri
ID: Müşterinin benzersiz kimliği
İsim ve Soyisim
Kimlik ve Telefon Numarası
Ödeme Kartı Bilgileri
Fonksiyonlar
*Müşteri ekleme, silme ve güncelleme
### Rezervasyonlar
Rezervasyon Bilgileri
ID: Rezervasyonun benzersiz kimliği
Giriş ve Çıkış Tarihleri
Ücret
Fonksiyonlar
Rezervasyon yapma ve iptal etme
### Faturalar
Fatura Bilgileri
ID: Faturanın benzersiz kimliği
Tarih ve Toplam Ücret
Fonksiyonlar
*Fatura hesaplama, kaydetme ve görüntüleme
## Kullanım Kılavuzu

** Yönetici Girişi: Sisteme giriş yaptıktan sonra yöneticiler, personel ve müşteri yönetimi gibi tüm işlemleri gerçekleştirebilir
** Personel İşlemleri: Yeni personel ekleyebilir, mevcut personel bilgilerini güncelleyebilir veya personeli sistemden silebilirsiniz
** Oda İşlemleri: Otelin odalarını sisteme ekleyebilir, oda durumlarını değiştirebilir veya odaları görüntüleyebilirsiniz
** Müşteri İşlemleri: Yeni müşteriler ekleyebilir, müşteri bilgilerini güncelleyebilir veya müşterileri silebilirsiniz
** Rezervasyon İşlemleri: Rezervasyon yapabilir, iptal edebilir ve mevcut rezervasyonları görüntüleyebilirsiniz
** Fatura İşlemleri: Rezervasyonlara bağlı olarak fatura oluşturabilir, kaydedebilir ve görüntüleyebilirsiniz

## Teknik Bilgiler
### Veritabanı Yapısı
#### Tablolar

** Yönetici
* YoneticiID, YoneticiIsim, YoneticiSoyisim, YoneticiKimlik, YoneticiTelefonNo, YoneticiSifre, YoneticiGuvenlikSoru, YoneticiGuvenlikCevap
** Personel
* PersonelID, PersonelIsim, PersonelSoyisim, PersonelKimlik, PersonelTelefonNo, PersonelPozisyon
** Oda
* OdaID, OdaNumarasi, OdaTur, OdaFiyat, OdaDurum
** Müşteri
*  MusteriID, MusteriIsim, MusteriSoyisim, MusteriKimlik, MusteriTelefonNo, MusteriOdemeKart
** Rezervasyon
* RezervasyonID, GirisTarih, CikisTarih, Ucret
** Fatura
* FaturaID, Tarih, ToplamUcret

