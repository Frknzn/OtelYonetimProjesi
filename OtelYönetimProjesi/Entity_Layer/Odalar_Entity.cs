using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYönetimProjesi.Entity_Layer
{
    public class Odalar_Entity
    {
        public int Oda_ID { get => Oda_ID; set => Oda_ID = value; }
        public int Oda_Numarasi {  get => Oda_Numarasi; set => Oda_Numarasi = value;}
        public string Oda_Tur { get => Oda_Tur; set => Oda_Tur = value; }
        public int Oda_Fiyat { get => Oda_Fiyat; set => Oda_Fiyat = value;}

    }
}
