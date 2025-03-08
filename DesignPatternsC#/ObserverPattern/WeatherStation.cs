using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.ObserverPattern
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        // Step 5: Notify all observers about the update
        public void NotifyObservers()
        {
            foreach(var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }

        // Step 4: Implementing Register and Remove methods to manage observers
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Step 6: Method to set the temperature and notify observers
        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }
    }
}
