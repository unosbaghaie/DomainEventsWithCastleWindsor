using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventsWithCastleWindsor.Business
{
    public class UserWasRegisteredHandler : IHandles<UserWasRegistered>
    {
        public void Handle(UserWasRegistered args)
        {
            Console.WriteLine("{0:c} was Mailed '{1}'", args.Id, args.Email);
        }
       
    }
}
