namespace ObserverPattern.Observer;

public class Observer: IObserver
{
    private static int _nextId;
    private int Id { get; }

    public Observer()
    {
        Id = Interlocked.Increment(ref _nextId);
    }

    public void Update(float temp, float humidity, float pressure)
    {
        Console.WriteLine($"Observer with ID#{Id} notified!");
    }
}