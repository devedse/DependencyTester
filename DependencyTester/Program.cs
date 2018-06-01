using System;

namespace DependencyTester
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfigurator.CreateContainer();


            var calc = container.Resolve<ICalculator>();

            calc.DoeIets();


            Console.ReadLine();

        }
    }
}
