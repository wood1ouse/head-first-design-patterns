using ObserverPattern.DisplayElement;
using ObserverPattern.Subject;

namespace ObserverPattern.Observer;

public class CurrentConditionsDisplay: IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        weatherData.RegisterObserver(this);
    }
    
    public void Update(float temp, float humidity, float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature} F degrees and {_humidity} % humidity");
    }
}