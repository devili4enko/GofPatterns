using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    enum WeatherEnum
    {
        Rain, Sun, Snow
    }

    class Weather
    {
        public static string GetWeather()
        {
            var a = new Random().Next(0, 2);
            return ((WeatherEnum)a).ToString();
        }
    }
}
