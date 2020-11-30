using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            comboBox1.Items.AddRange(new string[] {
                "Донецк", "Макеевка", "Горловка", "Енакиево", "Ждановка",
                "Авдеевка", "Амвросиевка", "Красногоровка", "Волноваха", "Бахмут",
                "Дебальцево", "Докучаевск", "Иловайск", "Харцызск",
                "Новоазовск", "Ясиноватая", "Константиновка", "Дружковка" });

            comboBox1.SelectedIndex = 0;
        }

        private void GetInfo(string city)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&appid=13af0d30031321176547143713e422d8&units=metric&lang=ru";
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            StreamReader stream = new StreamReader(res.GetResponseStream());
            string response = stream.ReadToEnd();

            WeatherResponse wr = JsonConvert.DeserializeObject<WeatherResponse>(response);
            countryCity.Text = "Украина, " + wr.Name;
            temp.Text = wr.Main.Temp.ToString() + "°C";
            description.Text = wr.Weather[0].Description;
            pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + "/img/" + wr.Weather[0].Icon + ".png");
            presHum.Text = "Давление: " + wr.Main.Pressure.ToString() + " мм рт. ст. Влажность: " + wr.Main.Humidity.ToString() + "%";
            windVis.Text = "Ветер: " + wr.Wind.Speed.ToString() + " м/c (" + wr.Wind.Deg.ToString() + "°). Видимость: " + wr.Visibility.ToString() + " м";
            sunrise.Text = "Восход: " + ConvertFromUnixTimestamp(wr.Sys.Sunrise);
            sunset.Text = "Закат: " + ConvertFromUnixTimestamp(wr.Sys.Sunset);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            datetime.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private string ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp).ToLocalTime().ToShortTimeString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInfo(comboBox1.SelectedItem.ToString());
        }
    }
}
