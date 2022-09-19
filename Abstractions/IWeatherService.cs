namespace Abstractions
{
    public interface IWeatherService
    {
        decimal Temperature(string placeName);
    }
}