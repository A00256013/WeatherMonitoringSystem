using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Interface for all display elements.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Displays the current weather data on the display.
        /// </summary>
        void Display();
    }
}
