using VariableBehaviour.Behaviour.Fly;
using VariableBehaviour.Behaviour.Quack;

namespace VariableBehaviour;

public class ModelDuck() : Duck(flyBehaviour: new FlyNoWay(), quackBehaviour: new QuackAsUsual())
{
    public override void Display()
    {
        Console.WriteLine("I'm a model Duck!");
    }
}