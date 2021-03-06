﻿using OpenWeatherMap;
using System.Threading.Tasks;


namespace Plugin.Sample.Condition.Services
{
    public class WeatherService
    {
        private string applicationId;

        public WeatherService(string applicationId)
        {
            this.applicationId = applicationId; 
        }

        public async Task<Temperature> GetCurrentTemperature(string city, string country)
        {
            var client = new OpenWeatherMapClient(this.applicationId);

            var currentWeather = await client.CurrentWeather.GetByName($"{city}, {country}", MetricSystem.Metric);

            return currentWeather.Temperature;
        }
    }
}
