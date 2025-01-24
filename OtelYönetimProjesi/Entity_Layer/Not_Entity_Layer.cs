using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYönetimProjesi.Entity_Layer
{
    public class Not_Entity_Layer
    {
        //public int Not_ID { get => Not_ID; set=> Not_ID = value; }

        //public string Not_Metin {  get => Not_Metin; set => Not_Metin = value;}

        //public DateTime Not_Tarih { get => Not_Tarih; set => Not_Tarih = value; }   

        //public string Yonetici_Isim {  get => Yonetici_Isim; set => Yonetici_Isim = value;}

        //public string Yonetici_Soyisim { get => Yonetici_Soyisim; set => Yonetici_Soyisim = value; }

        private int _notId;
        private string _notMetin;
        private DateTime _notTarih;
        private string _yoneticiIsim;
        private string _yoneticiSoyisim;

        public int Not_ID
        {
            get => _notId;
            set => _notId = value;
        }

        public string Not_Metin
        {
            get => _notMetin;
            set => _notMetin = value;
        }

        public DateTime Not_Tarih
        {
            get => _notTarih;
            set => _notTarih = value;
        }

        public string Yonetici_Isim
        {
            get => _yoneticiIsim;
            set => _yoneticiIsim = value;
        }

        public string Yonetici_Soyisim
        {
            get => _yoneticiSoyisim;
            set => _yoneticiSoyisim = value;
        }

    }
}
