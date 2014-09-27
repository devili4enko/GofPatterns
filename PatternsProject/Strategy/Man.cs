using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Man
    {
        public void GoOutSide()
        {
            var weather = Weather.GetWeather();

            var clothes = GetCloses(weather);
            var accessories = GetAccessories(weather);

            Console.WriteLine("Today {0} weather and I wear {1} with {2}", weather, clothes, accessories);
        }

        private string GetAccessories(string weather)
        {
            switch (weather.ToLower())
            {
                case "rain":
                    return "coat";
                case "sun":
                    return "T-Shirt";
                case "snow":
                    return "Sweater";
                default:
                    return "Shirt";
            }
        }

        private string GetCloses(string weather)
        {
            switch (weather.ToLower())
            {
                case "rain":
                    return "umbrella";
                case "sun":
                    return "sun glasses";
                case "snow":
                    return "snowboard";
                default:
                    return "nothing";
            }
        }
    }
}
