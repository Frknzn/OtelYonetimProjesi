using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYönetimProjesi.Entity_Layer
{
    public class Yonetici_Entity
    {

        public int Yonetici_ID { get => Yonetici_ID; set => Yonetici_ID = value; }
        public string Yonetici_Isim { get => Yonetici_Isim; set => Yonetici_Isim = value; }
        public string Yonetici_Soyisim { get => Yonetici_Soyisim; set => Yonetici_Soyisim = value; }
        public int Yonetici_Kimlik { get => Yonetici_Kimlik ; set => Yonetici_Kimlik = value; }
        public int Yonetici_Sifre { get => Yonetici_Sifre; set => Yonetici_Sifre = value; }
        public string Yonetici_Guvenlik_Soru { get => Yonetici_Guvenlik_Soru; set => Yonetici_Guvenlik_Soru = value; }
        public string Yonetici_Guvenlik_Cevap { get => Yonetici_Guvenlik_Cevap; set => Yonetici_Guvenlik_Cevap = value; }
        public int Yonetici_Tel_Numarasi { get => Yonetici_Tel_Numarasi; set => Yonetici_Tel_Numarasi = value; }

    }
}
