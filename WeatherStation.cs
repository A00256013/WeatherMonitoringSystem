using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Factory for creating different types of displays.
    /// </summary>
    public class WeatherStation
    {
        /// <summary>
        /// Creates a display object.
        /// </summary>
        /// <param name="displayType">The type of display to create.</param>
        /// <returns>A display object.</returns>
        public IDisplay CreateDisplay(string displayType)
        {
            switch (displayType)
            {
                case "CurrentConditions":
                    return new CurrentConditionsDisplay();
                case "Statistics":
                    return new StatisticsDisplay();
                case "Forecast":
                    return new ForecastDisplay();
                default:
                    return null;
            }
        }
    }
}
