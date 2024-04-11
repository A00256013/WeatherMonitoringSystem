using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Displays weather forecast.
    /// </summary>
    public class ForecastDisplay : IDisplay
    {
        /// <summary>
        /// Displays weather forecast.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Displaying weather forecast...");
        }
    }
}
