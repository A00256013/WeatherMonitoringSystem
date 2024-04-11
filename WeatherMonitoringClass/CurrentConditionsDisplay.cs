using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringClass
{
    /// <summary>
    /// This class represents a display that shows the current weather conditions. It's an observer of the WeatherData and a decorator that can add additional information to the display.
    /// </summary>
    public class CurrentConditionsDisplay : IDisplay
    {
        /// <summary>
        /// Displays the current weather conditions.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Current conditions: 80F degrees and 65% humidity");
        }
    }

}
