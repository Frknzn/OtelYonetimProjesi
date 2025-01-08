using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYönetimProjesi
{
    public partial class Guvenlik_Katmanı : Form
    {
        public bool Onay {  get; set; }
        public Guvenlik_Katmanı()
        {
            InitializeComponent();
            Onay = false;
            
        }

        private void GuvenlikKoduVerbtn_Click(object sender, EventArgs e)
        {
            Random kod = new Random();
            int randomNumber = kod.Next(1000,10000);
            GuvenlikKodutxt.Text = randomNumber.ToString();
        }

        private void Onaybtn_Click(object sender, EventArgs e)
        {
            if (GuvenlikKodutxt.Text == GuvenlikKoduGirtxt.Text)
            {
                MessageBox.Show("İşlem Onayı");  
                Onay = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hata : İşlem onaylanmadı");
                Onay = false;
            }
        }

        private void GuvenlikCıkısbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
