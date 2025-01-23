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
    public partial class Fatura_Kayıt_Ekranı : UserControl
    {
        public Fatura_Kayıt_Ekranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Yonetici_DAL.FaturaKayıtGoruntule(FaturaKayıtGridViev))
            //{

            //}
        }

        private void Fatura_Kayıt_Ekranı_Load(object sender, EventArgs e)
        {
            Yonetici_DAL.FaturaKayıtGoruntule(FaturaKayıtGridViev);
        }
    }
}
