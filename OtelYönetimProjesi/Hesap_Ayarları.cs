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
    public partial class Hesap_Ayarları : UserControl
    {
        public Hesap_Ayarları()
        {
            InitializeComponent();
        }

        private void HesapGuncenllebtn_Click(object sender, EventArgs e)
        {
            try
            {
               var islem = Yonetici_Bussiness_Layer.HesapAyarlariGuncelleBLL(Hesapİsimtxt.Text, HesapSoyisimtxt.Text, HesapTeltxt.Text, HesapGuvenlikSorutxt.Text, HesapGuvenlikCevaptxt.Text, HesapSifretxt.Text, HesapSifreTekrartxt.Text);
                MessageBox.Show(islem.mesaj);
                if (islem.basarili)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        
    }
    
}
