using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Displays current weather conditions.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        private readonly WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
        }

        public void Display()
        {
            // Display current weather conditions
            Console.WriteLine("Current conditions: Temperature {0}°C, Humidity {1}%",
                               weatherData.GetTemperature(), weatherData.GetHumidity());
        }
    }
}
