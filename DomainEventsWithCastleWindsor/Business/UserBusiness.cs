using DomainEventsWithCastleWindsor.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEventsWithCastleWindsor.Business
{
    public class UserBusiness : IUserBusiness
    {
        public int Id { get; set; }
        public string Email { get; set; }


        public void RegisterUser()
        {

            // register user 


            DomainEventDispatcher.Raise(new UserWasRegistered() { Id = Id, Email = Email });
        }

    }
}
