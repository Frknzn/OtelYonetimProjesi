using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYönetimProjesi.Entity_Layer
{
    public class Rezervasyonlar_Entity
    {
        public int Rezervasyon_ID { get => Rezervasyon_ID; set => Rezervasyon_ID = value; }
        public int Musteri_ID {  get => Musteri_ID; set => Musteri_ID = value;}
        public int Oda_ID { get => Oda_ID; set => Oda_ID = value; }
        public int Musteri_Kimlik_Numarasi { get => Musteri_Kimlik_Numarasi; set => Musteri_Kimlik_Numarasi = value; }
        public string Musteri_Isim { get => Musteri_Isim; set => Musteri_Isim = value; }
        public string Musteri_Soyisim { get => Musteri_Soyisim; set => Musteri_Soyisim = value; }

        public DateTime Giris_Tarih {  get => Giris_Tarih; set => Giris_Tarih = value;}
        public DateTime Cikis_Tarih { get => Cikis_Tarih; set => Cikis_Tarih = value; }


    }
}
