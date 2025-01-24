# OtelYonetimProjesi
## Proje Hakkında
Bu proje, otel personeli ve yöneticiler için günlük operasyonları kolaylaştırmayı hedefleyen bir otel yönetim sistemidir.

## Özellikler

### Yöneticiler
* **Yönetici Bilgileri**
  * ID: Yöneticinin benzersiz kimliği
  * İsim ve Soyisim
  * Kimlik Numarası
  * Telefon Numarası
  * Şifre, Güvenlik Sorusu ve Cevabı
* **Fonksiyonlar**
  * Müşteri, personel, oda, rezervasyon ve fatura bilgilerini düzenleme ve görüntüleme
  * Yeni yöneticiler ekleme

### Personel
* **Personel Bilgileri**
  * ID: Personelin benzersiz kimliği
  * İsim ve Soyisim
  * Kimlik ve Telefon Numarası
  * Pozisyon
* **Fonksiyonlar**
  * Personel ekleme, silme ve güncelleme

### Odalar
* **Oda Bilgileri**
  * ID: Odanın benzersiz kimliği
  * Numara, Tür, Fiyat ve Durum
* **Fonksiyonlar**
  * Oda ekleme, silme ve güncelleme

### Müşteriler
* **Müşteri Bilgileri**
  * ID: Müşterinin benzersiz kimliği
  * İsim ve Soyisim
  * Kimlik ve Telefon Numarası
  * Ödeme Kartı Bilgileri
* **Fonksiyonlar**
  * Müşteri ekleme, silme ve güncelleme

### Rezervasyonlar
* **Rezervasyon Bilgileri**
  * ID: Rezervasyonun benzersiz kimliği
  * Giriş ve Çıkış Tarihleri
  * Ücret
* **Fonksiyonlar**
  * Rezervasyon yapma ve iptal etme

### Faturalar
* **Fatura Bilgileri**
  * ID: Faturanın benzersiz kimliği
  * Tarih ve Toplam Ücret
* **Fonksiyonlar**
  * Fatura hesaplama, kaydetme ve görüntüleme

## Kullanım Kılavuzu
1. **Yönetici Girişi**: Sisteme giriş yaptıktan sonra yöneticiler, personel ve müşteri yönetimi gibi tüm işlemleri gerçekleştirebilir
2. **Personel İşlemleri**: Yeni personel ekleyebilir, mevcut personel bilgilerini güncelleyebilir veya personeli sistemden silebilirsiniz
3. **Oda İşlemleri**: Otelin odalarını sisteme ekleyebilir, oda durumlarını değiştirebilir veya odaları görüntüleyebilirsiniz
4. **Müşteri İşlemleri**: Yeni müşteriler ekleyebilir, müşteri bilgilerini güncelleyebilir veya müşterileri silebilirsiniz
5. **Rezervasyon İşlemleri**: Rezervasyon yapabilir, iptal edebilir ve mevcut rezervasyonları görüntüleyebilirsiniz
6. **Fatura İşlemleri**: Rezervasyonlara bağlı olarak fatura oluşturabilir, kaydedebilir ve görüntüleyebilirsiniz

## Teknik Bilgiler

### Veritabanı Yapısı

#### Tablolar
1. **Yönetici**
   * YoneticiID, YoneticiIsim, YoneticiSoyisim, YoneticiKimlik, YoneticiTelefonNo, YoneticiSifre, YoneticiGuvenlikSoru, YoneticiGuvenlikCevap

2. **Personel**
   * PersonelID, PersonelIsim, PersonelSoyisim, PersonelKimlik, PersonelTelefonNo, PersonelPozisyon

3. **Oda**
   * OdaID, OdaNumarasi, OdaTur, OdaFiyat, OdaDurum

4. **Müşteri**
   * MusteriID, MusteriIsim, MusteriSoyisim, MusteriKimlik, MusteriTelefonNo, MusteriOdemeKart

5. **Rezervasyon**
   * RezervasyonID, GirisTarih, CikisTarih, Ucret

6. **Fatura**
   * FaturaID, Tarih, ToplamUcret
  * Uygulamadan bazı görseller.
    ![image](https://github.com/user-attachments/assets/5dbdaf43-d970-47a4-afd9-30eb393a0cce)
    ![image](https://github.com/user-attachments/assets/13097b30-0a72-4fcc-9cec-9f57b3f10eca)
    ![image](https://github.com/user-attachments/assets/896f8105-59a6-4762-8896-731760a69d3a)

