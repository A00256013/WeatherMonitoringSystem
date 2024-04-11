using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringClass
{
    public class ForecastDisplay : IDisplay
    {
        /// <summary>
        /// Displays the weather forecast.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Improving weather on the way!");
        }
    }
}
