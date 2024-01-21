using VariableBehaviour.Behaviour.Fly;
using VariableBehaviour.Behaviour.Quack;

namespace VariableBehaviour;

public abstract class Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
{
    public IFlyBehaviour FlyBehaviour
    {
        get => flyBehaviour;
        set => flyBehaviour = value;
    }

    private IQuackBehaviour QuackBehaviour
    {
        get => quackBehaviour;
        set => quackBehaviour = value;
    }

    public abstract void Display();

    public void PerformFly()
    {
        FlyBehaviour.Fly();
    }

    public void PerformQuack()
    {
        QuackBehaviour.Quack();
    }
}