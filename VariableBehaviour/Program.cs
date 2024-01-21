using VariableBehaviour.Behaviour.Fly;

namespace VariableBehaviour;

class Program
{
    static void Main(string[] args)
    {
        // var mallardDuck = new MallardDuck();
        //
        // mallardDuck.Display();
        // mallardDuck.PerformFly();
        // mallardDuck.PerformQuack();

        Duck model = new ModelDuck();
        
        model.Display();
        model.PerformFly();
        // It would be impossible if Fly Behaviour implementation would be inside Duck class
        model.FlyBehaviour = new FlyPowered();
        model.PerformFly();
    }
}