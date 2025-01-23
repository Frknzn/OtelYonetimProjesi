using Newtonsoft.Json;
using OtelYönetimProjesi.Business_Layer;
using OtelYönetimProjesi.Data_Access_Layer;
using OtelYönetimProjesi.Entity_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYönetimProjesi
{
    public partial class Yonetici_Ana_Sayfa : UserControl
    {
        private readonly Yonetici_Bussiness_Layer yonetici_Bussiness_Layer;

       
        public Yonetici_Ana_Sayfa()
        {
            InitializeComponent();
            yonetici_Bussiness_Layer = new Yonetici_Bussiness_Layer();

            

            //this.ParentChanged += Yonetici_Ana_Sayfa_ParentChanged;
        }

        private void HavaDurumuGetir()
        {
            var lblSicaklik = new Label
            {
                AutoSize = true,
                Location = new Point(10,10),
                Font = new Font("Segoe UI", 10, FontStyle.Bold | FontStyle.Italic),
            };

            var lblNem = new Label
            {
                AutoSize = true,
                Location = new Point(10, 40)
            };

            var lblDurum = new Label
            {
                AutoSize = true,
                Location = new Point(10, 70)
            };

            var picHavaDurumu = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(140, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            HavaDurumuPanel.Controls.AddRange(new Control[] {
        lblSicaklik,
        lblNem,
        lblDurum,
        picHavaDurumu
    });

            _ = HavaDurumuGuncelle();

            async Task HavaDurumuGuncelle()
            {
                string apiKey = "5299b5968563a891ccbbd1f406b75a1c";
                try
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetStringAsync(
                            $"http://api.openweathermap.org/data/2.5/weather?q=Amasya&appid={apiKey}&units=metric&lang=tr"
                        );
                        var weather = JsonConvert.DeserializeObject<WeatherResponse>(response);

                        lblSicaklik.Text = $"{Math.Round(weather.Main.Temp)}°C";
                        lblNem.Text = $"Nem: {weather.Main.Humidity}%";
                        lblDurum.Text = weather.Weather[0].Description;

                        var iconResponse = await client.GetByteArrayAsync(
                   $"http://openweathermap.org/img/w/{weather.Weather[0].Icon}.png"
               );
                        using (var ms = new MemoryStream(iconResponse))
                        {
                            picHavaDurumu.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hava durumu bilgisi alınamadı: {ex.Message}");
                }
            }
        }
        public class WeatherResponse
        {
            public MainInfo Main { get; set; }
            public WeatherInfo[] Weather { get; set; }
        }

        public class MainInfo
        {
            public double Temp { get; set; }
            public int Humidity { get; set; }
        }

        public class WeatherInfo
        {
            public string Description { get; set; }
            public string Icon { get; set; }
        }



        private void YoneticiKimlikKartlbl_Click(object sender, EventArgs e)
        {

        }


        //private TextBox YoneticiBilgiİsim;
        //private TextBox YoneticiBilgiSoyisim;
        //private TextBox YoneticiBilgiKimlik;
        //private TextBox YoneticiBilgiTel;
        private void Yonetici_Ana_Sayfa_Load(object sender, EventArgs e)
        {
            try
            {
                int yoneticiKimlik = Giren_Yonetici_ID.GirisYapanYoneticiID;
                

                Console.WriteLine("Yonetici ID" + yoneticiKimlik);
                if (yoneticiKimlik <= 0)
                {
                   // MessageBox.Show("Geçerli Yonetici ID bulunamadı ");
                    return;
                }
                var yoneticiBilgileri = Yonetici_DAL.YoneticiBilgiGetir(yoneticiKimlik);

                if(yoneticiBilgileri.Yoneticiİsim != null)
                {
                    YoneticiBilgiİsimtxt.Text =  yoneticiBilgileri.Yoneticiİsim;
                    YoneticiBilgiSoyisimtxt.Text = yoneticiBilgileri.YoneticiSoyisim;
                    YoneticiBilgiKimliktxt.Text = yoneticiBilgileri.YoneticiKimlik;
                    YoneticiBilgiTeltxt.Text = yoneticiBilgileri.YoneticiTelNumarasi;

                    YoneticiBilgiİsimtxt.ReadOnly = true;
                    YoneticiBilgiSoyisimtxt.ReadOnly = true;
                    YoneticiBilgiKimliktxt.ReadOnly = true;
                    YoneticiBilgiTeltxt.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Yönetici Bilgileri getirilemedi");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SayilariGuncelle();
            HavaDurumuGetir();
                
            
        }

        private void Yonetici_Ana_Sayfa_Activated (object sender, EventArgs e)
        {
            SayilariGuncelle();
        }

        public void SayilariGuncelle()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                MusteriSayitxtbox.Text = yonetici_Bussiness_Layer.MusteriSayisiGetirBLL().ToString();
                OdaSayıtxtbox.Text = yonetici_Bussiness_Layer.OdaSayisiGetirBLL().ToString();
                PersonelSayitxtbox.Text = yonetici_Bussiness_Layer.PersonelSayisiGetirBLL().ToString();
                RezervasyonSayitxtbox.Text = yonetici_Bussiness_Layer.RezervasyonSayisiGetirBLL().ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void YoneticiBilgiTeltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Yonetici_Ana_Sayfa_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                SayilariGuncelle();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Yonetici_Ana_Sayfa_ParentChanged(object sender, EventArgs e)
        {
            
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            
        }
    }
}
