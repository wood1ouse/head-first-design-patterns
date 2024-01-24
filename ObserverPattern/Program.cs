using ObserverPattern.Observer;
using ObserverPattern.Subject;

public class Program
{
    static void Main(string[] args)
    {
        // Example with manual registering of observables
        var weatherData = new WeatherData();

        var observer1 = new Observer();
        var observer2 = new Observer();
        var observer3 = new Observer();
        
        weatherData.RegisterObserver(observer1);
        weatherData.RegisterObserver(observer2);
        weatherData.RegisterObserver(observer3);
        
        // Example with CurrentConditionsDisplay instance
        var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

        // Changes in Weather Data instance. If prev change == current change - it will be ignored. 
        weatherData.Humidity = 100f;
        weatherData.Temperature = 100f;
        weatherData.Humidity = 100f;
    }
}