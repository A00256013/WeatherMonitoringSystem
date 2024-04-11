using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringClass
{
    /// <summary>
    /// This is a singleton class that represents the weather data. It collects weather data and notifies observers when the data changes.
    /// </summary>
    public sealed class WeatherData
    {
        private static WeatherData _instance;
        private static readonly object padlock = new object();

        /// <summary>
        /// Private constructor to prevent instance creation.
        /// </summary>
        private WeatherData() { }

        /// <summary>
        /// Gets the singleton instance of the WeatherData class.
        /// </summary>
        public static WeatherData Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new WeatherData();
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Collects the weather data. In this method, we simulate data collection by generating random data for temperature, humidity, and pressure.
        /// </summary>
        public void CollectData()
        {
            // Simulate data collection by generating random data
            Random random = new Random();
            double temperature = random.NextDouble() * 100;
            double humidity = random.NextDouble() * 100;
            double pressure = random.NextDouble() * 100;

            // Notify observers with the new data
            NotifyObservers(temperature, humidity, pressure);
        }

        /// <summary>
        /// Notifies all observers about a data change.
        /// </summary>
        /// <param name="temperature">The current temperature.</param>
        /// <param name="humidity">The current humidity.</param>
        /// <param name="pressure">The current pressure.</param>
        private void NotifyObservers(double temperature, double humidity, double pressure)
        {
            // TODO: Implement the logic to notify observers
        }
    }
}
