using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepozitorijum
    {
        Broker broker = new Broker();

        public User LogIn(User user)
        {
            try
            {
                broker.OpenConnection();
                return broker.LogIn(user);
            } finally
            {
                broker.CloseConnection();
            }
        }
    }
}
