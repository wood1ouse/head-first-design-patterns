namespace VariableBehaviour.Behaviour.Fly;

public class FlyNoWay: IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("Can't Fly!");
    }
}