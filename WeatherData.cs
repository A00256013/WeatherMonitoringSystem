using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem
{
    /// <summary>
    /// Weather data subject (Singleton).
    /// </summary>
    public class WeatherData
    {
        private static WeatherData instance;
        private double temperature;
        private double humidity;
        private string forecast;

        private WeatherData() { }

        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        public void SetMeasurements(double temperature, double humidity, string forecast)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.forecast = forecast;
            NotifyObservers();
        }

        public double GetTemperature()
        {
            return temperature;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public string GetForecast()
        {
            return forecast;
        }

        // Other methods for weather data management...

        private List<IDisplay> observers = new List<IDisplay>();

        public void RegisterObserver(IDisplay observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IDisplay observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Display();
            }
        }
    }

}