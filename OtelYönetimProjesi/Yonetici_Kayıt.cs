using Mysqlx;
using OtelYönetimProjesi.Business_Layer;
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
    public partial class Yonetici_Kayıt : UserControl
    {
        public Yonetici_Kayıt()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void YeniYoneticiKayıtbtn_Click(object sender, EventArgs e)
        {
            

            


            
            string yoneticiIsim = YeniYoneticiİsimtxt.Text.Trim();
            string yoneticiSoyisim = YeniYoneticiSoyisimtxt.Text.Trim();
            string yoneticiKimlik = YeniYoneticiKimliktxt.Text.Trim();
            int yoneticiSifre;
            int yoneticiSifreTekrar;
            string yoneticiGuvenlikSoru = YeniYoneticiGuvenlikSorutxt.Text.Trim();
            string yoneticiGuvenlikCevap = YeniYoneticiGuvenlikCevaptxt.Text.Trim();
            string yoneticiTelNumarasi = YeniYoneticiTeltxt.Text.Trim();

            
            if (!int.TryParse(YeniYoneticiSifretxt.Text.Trim(), out yoneticiSifre) ||
                !int.TryParse(YeniYoneticiSifreTekrartxt.Text.Trim(), out yoneticiSifreTekrar))
            {
                MessageBox.Show("Şifreler geçerli bir sayı olmalıdır.");
                return;
            }

            
            var (basarili, mesaj) = Yonetici_Bussiness_Layer.YeniYoneticiKayitBLL(yoneticiIsim, yoneticiSoyisim, yoneticiKimlik, yoneticiSifre, yoneticiSifreTekrar, yoneticiGuvenlikSoru, yoneticiGuvenlikCevap, yoneticiTelNumarasi);

            
            MessageBox.Show(mesaj);
        }
    }
}
