using ObserverPattern.Observer;

namespace ObserverPattern.Subject;

public class WeatherData: ISubject
{
    private readonly List<IObserver> _observers = [];

    private float _temperature;
    
    private float _humidity;

    private float _pressure;

    public float Temperature
    {
        get => _temperature;
        set
        {
            if (value == _temperature) return;
            _temperature = value;
            NotifyObservers();
        }
    }

    public float Humidity
    {
        get => _humidity;
        set
        {
            if (value == _humidity) return;
            _humidity = value;
            NotifyObservers();
        }
    }

    private float Pressure
    {
        get => _pressure;
        set
        {
            if (value == _pressure) return;
            _pressure = value;
            NotifyObservers();
        }
    }

    public void NotifyObservers()
    {
        if (_observers.Count == 0) return;
        foreach (var observer in _observers)
        {
            observer.Update(Temperature, Humidity, Pressure);
        }
    }

    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }
}