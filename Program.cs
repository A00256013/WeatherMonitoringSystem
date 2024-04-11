using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            // Example: Create and display CurrentConditionsDisplay
            IDisplay currentDisplay = weatherStation.CreateDisplay("current");
            currentDisplay.Display();

            // Example: Create and display StatisticsDisplay
            IDisplay statisticsDisplay = weatherStation.CreateDisplay("statistics");
            statisticsDisplay.Display();

            // Example: Create and display ForecastDisplay
            IDisplay forecastDisplay = weatherStation.CreateDisplay("forecast");
            forecastDisplay.Display();
        }
    }
    
}
