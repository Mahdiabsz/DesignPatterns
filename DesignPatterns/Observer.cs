using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }
    class WeatherStation: ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        public float Temperature 
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Notify();
            }
        }
        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }
    interface IObserver
    {
        void Update(ISubject subject);
    }
    class NewsAgency : IObserver
    {
        public string AgencyName { get; set; }
        public NewsAgency(string name)
        {
            AgencyName = name;
        }

        public void Update(ISubject subject)
        {
            if(subject is WeatherStation weatherStation)
            {
                Console.WriteLine("{0} reporting temperature {1} degree celcius.",
                    AgencyName, weatherStation.Temperature);
            }
        }
    }
}
