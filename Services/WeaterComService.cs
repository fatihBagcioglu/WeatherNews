using Abstractions;

namespace Services
{
    public class WeaterComService : IWeatherService
    {
        public decimal GetForecast(string place)
        {
            // weather.com
            switch (place.ToLower())
            {
                case "ankara":
                    return 27m;
                case "izmir":
                    return 31m;
                case "bursa":
                    return 28m;
                case "adana":
                    return 32m;
                default:
                    return new Random().Next(10, 20);
            }
        }

        public decimal Temperature(string placeName)
        {
            return GetForecast(placeName);
        }
    }
}