using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringClass
{
    /// <summary>
    /// Creates a display of the specified type.
    /// </summary>
    /// <param name="type">The type of display to create.</param>
    /// <returns>A display of the specified type.</returns>
    public IDisplay CreateDisplay(string type)
    {
        switch (type)
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
