using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndyWeather
{
    class CityWeather
    {
        //城市名字
        public string city_name { get; set; }
        //最后更新时间
        public string last_update { get; set; }

        public NowWeather now { get; set; }

        public TodayWeather today { get; set; }

        public List<FutureWeather> future { get; set; }

    }

    class NowWeather
    {
        //天气
        public string text { get; set; }
        //温度
        public string temperature { get; set; }
        //体感温度
        public string feels_like { get; set; }
        //风向
        public string wind_direction { get; set; }
        //风速
        public float wind_speed { get; set; }

    }
    //今天天气
    class TodayWeather
    {
        //日升
        public string sunrise { get; set; }
        //日落
        public string sunset { get; set; }
        //建议
        public Suggestion suggestion { get; set; }
        //建议类
        public class Suggestion
        {
            //着装
            public Detail dressing { get; set; }
            //紫外线
            public Detail uv { get; set; }
            //洗车
            public Detail carwashing { get; set; }
            //旅行
            public Detail travel { get; set; }
            //流感
            public Detail flu { get; set; }
            //运动
            public Detail sport { get; set; }
        }
        //着装类
        public class Detail
        {
            //描述
            public string brief { get; set; }
            //详细
            public string details { get; set; }
        }

    }
    //未来天气  9天
    class FutureWeather
    {
        public string data { get; set; }

        public int high { get; set; }

        public int low { get; set; }

        public string day { get; set; }

        public string text { get; set; }

        public string wind { get; set; }
    }
}
