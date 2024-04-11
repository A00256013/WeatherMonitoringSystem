using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Class that displays weather statistics.
    /// </summary>
    public class StatisticsDisplay : IDisplay
    {
        /// <summary>
        /// Displays weather statistics.
        /// </summary>
        public void Display()
        {
            // Register displays as observers
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.RegisterObserver(currentDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);
        }
    }
}
