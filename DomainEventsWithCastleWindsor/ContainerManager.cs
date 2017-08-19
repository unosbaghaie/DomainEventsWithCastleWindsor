using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using DomainEventsWithCastleWindsor.Business;
using DomainEventsWithCastleWindsor.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventsWithCastleWindsor
{
    public static class ContainerManager
    {
        private static object locjObject = new object();

        private static IWindsorContainer container = null;
        public static IWindsorContainer Container
        {
            get
            {
                if (container == null)
                {
                    lock (locjObject)
                    {
                        // run installers, set _container = new container
                        BootstrapContainer();
                    }
                }
                return container;
            }
        }

        public static void BootstrapContainer()
        {

            if (container != null)
                return;

            container = new WindsorContainer().Install(FromAssembly.This());

            container.Register(Component.For<IUserBusiness>().ImplementedBy<UserBusiness>());
            //container.Register(Component.For<IHandles<UserWasRegistered>>().ImplementedBy<UserWasRegisteredHandler>());


            

            DomainEventDispatcher.SetContainer(container);

        }

        public static void Dispose()
        {
            //container.Dispose();
        }

      
    }
}
