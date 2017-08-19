using Castle.Windsor;
using DomainEventsWithCastleWindsor.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventsWithCastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContainerManager.BootstrapContainer();

            var user = new UserBusiness() { Id = 1, Email = "unos.bm65@gmail.com" };

            Console.WriteLine("id  '{0}' with email {1}", user.Id , user.Email);

            Console.WriteLine("About to Register user '{0}' ", user.Email);

            user.RegisterUser();

            Console.ReadLine();



        }
    }
}
