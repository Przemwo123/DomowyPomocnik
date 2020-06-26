using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgramForms.Forms
{
    public partial class Pogoda : Form
    {
        private enum StatusUpdate
        {
            notUpdate,
            UpdateProgress,
            UpdateOK
        }

        private static StatusUpdate status = StatusUpdate.notUpdate;
        private static string jsonResult = "";
        private static string source_url = "";
        private delegate void InvokeDelegate();

        public Pogoda()
        {
            InitializeComponent();
        }

        private void Pogoda_Load(object sender, EventArgs e)
        {
            switch (status)
            {
                case StatusUpdate.notUpdate:
                    NotUpdate();
                    if (cityNameLocation.Text != "")
                        UpdateWeatherStart();
                    break;
                case StatusUpdate.UpdateProgress:
                    UpdateProgress();
                    break;
                case StatusUpdate.UpdateOK:
                    UpdateOK();
                    break;

            }
        }

        private void btnUpdWeather_Click(object sender, EventArgs e)
        {
            if (cityNameLocation.Text != "")
                UpdateWeatherStart();
        }

        private void UpdateWeatherStart()
        {
            infoWeather.Text = "Ładowanie...";
            string cityNameLocation = this.cityNameLocation.Text;
            source_url = "http://api.openweathermap.org/data/2.5/find?q=" + cityNameLocation + "&mode=json&units=metric&lang=pl&APPID=52d37bc4cefeea304929b99bb714ed88";

            Thread weatherUpdate = new Thread(UpdateWeather);
            weatherUpdate.Start();

            status = StatusUpdate.UpdateProgress;
            UpdateProgress();
        }

        public void UpdateWeather()
        {
            while (Application.AllowQuit && status == StatusUpdate.UpdateProgress)
            {
                try
                {
                    WebClient webpage = new WebClient();
                    webpage.Encoding = Encoding.UTF8;
                    webpage.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                    jsonResult = webpage.DownloadString(source_url);

                    status = StatusUpdate.UpdateOK;

                    try
                    {
                        BeginInvoke(new InvokeDelegate(UpdateOK));
                    }
                    catch { }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    status = StatusUpdate.notUpdate;
                    BeginInvoke(new InvokeDelegate(NotUpdate));
                }

                Thread.Sleep(10);
            }
        }

        private void NotUpdate()
        {
            btnUpdWeather.Visible = true;
        }

        private void UpdateProgress()
        {
            btnUpdWeather.Visible = false;
        }

        private void UpdateOK()
        {
            try
            {
                dynamic data = JsonConvert.DeserializeObject<dynamic>(jsonResult);
                cityNameText.Text = data["list"][0]["name"].ToString();
                int temp = data["list"][0]["main"]["temp"];
                temText.Text = String.Format("{0}°", temp);
                infoWeather.Text = data["list"][0]["weather"][0]["description"].ToString();
                pictureBox1.Image = null;
                pictureBox1.ImageLocation = "http://openweathermap.org/img/w/" + data["list"][0]["weather"][0]["icon"] + ".png";
                btnUpdWeather.Visible = true;
            }
            catch
            {
                MessageBox.Show("Nieprawidłowa nazwa miasta!");
                NotUpdate();
            }
        }
    }
}
