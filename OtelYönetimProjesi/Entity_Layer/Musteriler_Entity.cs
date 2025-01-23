using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYönetimProjesi.Entity_Layer
{
    public class Musteriler_Entity
    {
        public int Musteri_ID { get => Musteri_ID; set => Musteri_ID = value; } 
        public string Musteri_Isim { get => Musteri_Isim; set => Musteri_Isim = value;}
        public string Musteri_Soyisim { get => Musteri_Soyisim; set => Musteri_Soyisim = value;}
        public int Musteri_Kimlik_Numarasi { get => Musteri_Kimlik_Numarasi; set => Musteri_Kimlik_Numarasi = value; }
        public int Musteri_Tel_Numarasi { get => Musteri_Kimlik_Numarasi; set => Musteri_Kimlik_Numarasi= value; }
        public int Musteri_Odeme_Kart { get => Musteri_Odeme_Kart; set => Musteri_Odeme_Kart = value; }
        

    } 
}
