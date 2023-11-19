using Newtonsoft.Json;
using System;
using System.Device.Location;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DomowyPomocnik.Forms
{
    [System.Security.SecurityCritical]
    public partial class Pogoda : Form
    {
        private static string currentCityName = "";

        private enum StatusUpdate
        {
            notUpdate,
            UpdateProgress,
            UpdateCoordinate,
            UpdateOK
        }

        private static StatusUpdate status = StatusUpdate.notUpdate;
        private static string jsonResult = "";
        private static string source_url = "";
        private delegate void InvokeDelegate();
        private delegate void InvokeDelegateError(string t);

        private static string cityName = "";
        private static string temp = "";
        private static string infoWeather = "";
        private static string pictureBox1Path = "";
        private static string currentrefreshTime = "";

        private GeoCoordinateWatcher coordinateWatcher;

        public Pogoda()
        {
            InitializeComponent();
        }

        private void Pogoda_Load(object sender, EventArgs e)
        {
            cityNameLocation.Text = currentCityName;

            switch (status)
            {
                case StatusUpdate.notUpdate:
                    NotUpdate();
                    if (source_url == "")
                    {
                        UpdateCoordinate();
                        Thread currentCityUpdate = new Thread(GetLocationEvent);
                        currentCityUpdate.Start();
                    }
                    else if (currentCityName == "")
                        UpdateWeatherStart();
                    else
                        UpdateWindowsScreen();
                    break;
                case StatusUpdate.UpdateProgress:
                    UpdateProgress();
                    break;
                case StatusUpdate.UpdateCoordinate:
                    if (source_url != "")
                        UpdateWeatherStart();
                    else
                        UpdateCoordinate();
                    break;
                case StatusUpdate.UpdateOK:
                    UpdateWindowsScreen();
                    break;
            }
        }

        private void BtnUpdWeather_Click(object sender, EventArgs e)
        {
            if (cityNameLocation.Text != "")
                UpdateWeatherStart();
        }

        private void RefreshLocationBtn_Click(object sender, EventArgs e)
        {
            currentCityName = "";
            source_url = "";
            UpdateCoordinate();
            Thread currentCityUpdate = new Thread(GetLocationEvent);
            currentCityUpdate.Start();
        }

        private void UpdateWeatherStart()
        {
            UpdateProgress();

            if (currentCityName != "")
                source_url = "http://api.openweathermap.org/data/2.5/find?q=" + cityNameLocation.Text + "&mode=json&units=metric&lang=pl&APPID=52d37bc4cefeea304929b99bb714ed88";

            Thread weatherUpdate = new Thread(UpdateWeather);
            weatherUpdate.Start();
        }

        private void UpdateWeather()
        {
            DateTime currentDateTime = DateTime.Now;
            currentrefreshTime = currentDateTime.ToString("HH:mm:ss");

            while (Application.AllowQuit && status == StatusUpdate.UpdateProgress)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    WebClient webpage = webClient;
                    webpage.Encoding = Encoding.UTF8;
                    webpage.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                    jsonResult = webpage.DownloadString(source_url);

                    status = StatusUpdate.UpdateOK;
                    dynamic data = JsonConvert.DeserializeObject<dynamic>(jsonResult);
                    if (data["count"] == "0")
                    {
                        BeginInvoke(new InvokeDelegateError(ErrorInfo), "Nie znaleziono miasta!");
                        break;
                    }
                    cityName = data["list"][0]["name"].ToString();
                    int _temp = data["list"][0]["main"]["temp"];
                    temp = String.Format("{0}°", _temp);
                    infoWeather = data["list"][0]["weather"][0]["description"].ToString();
                    pictureBox1Path = "http://openweathermap.org/img/w/" + data["list"][0]["weather"][0]["icon"] + ".png";
                    try
                    {
                        BeginInvoke(new InvokeDelegate(UpdateWindowsScreen));
                    }
                    catch
                    {

                    }
                }
                catch //(Exception ex)
                {
                    BeginInvoke(new InvokeDelegateError(ErrorInfo), "Nie udało się pobrać danych...");
                }
                Thread.Sleep(100);
                break;
            }
        }

        private void NotUpdate()
        {
            btnUpdWeather.Visible = true;
            cityNameLocation.Visible = true;
            refreshLocationBtn.Visible = true;
            myLocationLabel.Visible = true;
            status = StatusUpdate.notUpdate;
        }

        private void UpdateProgress()
        {
            infoWeatherText.Text = "Ładowanie...";
            btnUpdWeather.Visible = false;
            cityNameLocation.Visible = false;
            refreshLocationBtn.Visible = false;
            myLocationLabel.Visible = false;
            status = StatusUpdate.UpdateProgress;
        }
        private void UpdateCoordinate()
        {
            infoWeatherText.Text = "Ładowanie...";
            btnUpdWeather.Visible = false;
            cityNameLocation.Visible = false;
            refreshLocationBtn.Visible = false;
            myLocationLabel.Visible = false;
            status = StatusUpdate.UpdateCoordinate;
        }

        private void UpdateWindowsScreen()
        {
            NotUpdate();
            cityNameText.Text = cityName;
            temText.Text = temp;
            infoWeatherText.Text = infoWeather;
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = pictureBox1Path;
            currentCityName = cityName;
            refreshTime.Text = currentrefreshTime;
            cityNameLocation.Text = cityName;
        }

        private void ErrorInfo(string t)
        {
            NotUpdate();
            cityNameText.Text = t;
            temText.Text = "";
            infoWeatherText.Text = "";
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;
            refreshTime.Text = currentrefreshTime;
            cityNameLocation.Text = currentCityName;
        }

        private void GetLocationEvent()
        {
            coordinateWatcher = new GeoCoordinateWatcher();
            coordinateWatcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = coordinateWatcher.Position.Location;
            if (!coord.IsUnknown)
            {
                PrintPosition(coord.Latitude, coord.Longitude);
            }

            coordinateWatcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(Watcher_PositionChanged);
            int tempTime = 0;
            while (Application.AllowQuit && source_url == "")
            {
                if (tempTime > 2)
                {
                    Console.WriteLine("GeoCoordinateWatcher timed out on start.");
                    source_url = "http://api.openweathermap.org/data/2.5/find?q=Warszawa&mode=json&units=metric&lang=pl&APPID=52d37bc4cefeea304929b99bb714ed88";
                }
                Thread.Sleep(100);
                tempTime++;
            }

            try
            {
                if (currentCityName == "")
                    BeginInvoke(new InvokeDelegate(UpdateWeatherStart));
                else
                    BeginInvoke(new InvokeDelegate(NotUpdate));
            }
            catch
            {
            }
        }

        void Watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            PrintPosition(e.Position.Location.Latitude, e.Position.Location.Longitude);
        }

        void PrintPosition(double Latitude, double Longitude)
        {
            Console.WriteLine("lat: {0}, lon: {1}", Latitude, Longitude);
            source_url = "http://api.openweathermap.org/data/2.5/find?" + "lat=" + Latitude + "&lon=" + Longitude + "&mode=json&units=metric&lang=pl&APPID=52d37bc4cefeea304929b99bb714ed88";
        }
    }
}
