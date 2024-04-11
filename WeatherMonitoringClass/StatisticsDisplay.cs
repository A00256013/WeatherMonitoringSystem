using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringClass
{
    public class StatisticsDisplay : IDisplay
    {
        /// <summary>
        /// Displays the weather statistics.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = 80/85/75");
        }
    }
}
