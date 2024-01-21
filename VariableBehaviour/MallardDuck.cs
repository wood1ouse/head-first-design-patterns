using VariableBehaviour.Behaviour.Fly;
using VariableBehaviour.Behaviour.Quack;

namespace VariableBehaviour;

public class MallardDuck() : Duck(flyBehaviour: new FlyNoWay(), quackBehaviour: new QuackAsUsual())
{
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard Duck!");
    }
}