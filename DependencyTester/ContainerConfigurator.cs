using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyTester
{
    public static class ContainerConfigurator
    {
        public static WindsorContainer CreateContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IWindsorContainer>().Instance(container));
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());
            container.Register(Component.For<IWriter>().ImplementedBy<Writer>().LifestyleSingleton());
            container.Register(Component.For<ICalculator>().ImplementedBy<Calculator>());

            return container;
        }
    }
}
