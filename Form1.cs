using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using NPinyin;

namespace AndyWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //点击查询按钮
        private void button1_Click(object sender, EventArgs e)
        {
            string name = input_cityname.Text;

            string url = "https://weixin.jirengu.com/weather?location=" + name + "&key=study_javascript_in_jirengu.com";

            string str = GetWebClient(url);

            if (!String.IsNullOrEmpty(str))
            {
                JToken jt = JToken.Parse(str);
                JToken jsonWeather = jt["weather"].First;

                var weather = jsonWeather.ToObject<CityWeather>();
                message_text.Text = "查询成功！";
                update_time.Text = "最后更新时间：" + weather.last_update;

                city_name.Text = weather.city_name;
                city_weather.Text = weather.now.text;
                city_temper.Text = "当前温度：" + weather.now.temperature + "℃";
                wind.Text = weather.now.wind_direction + "风";
                wind_speed.Text = weather.now.wind_speed.ToString() + "m/s";

            }
            else
            {
                message_text.Text = "查询失败！";
            }          
        }

        /// <summary>
        /// 访问接口信息
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetWebClient(string url)
        {
            string strHTML = "";
          
            try
            {
                WebClient myWebClient = new WebClient();
                Stream myStream = myWebClient.OpenRead(url);
                StreamReader sr = new StreamReader(myStream, Encoding.GetEncoding("utf-8"));
                strHTML = sr.ReadToEnd();
                myStream.Close();
                myWebClient.Dispose();
                return strHTML;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
