using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MestoRepozitorijum
    {
        Broker broker = new Broker();
        public List<Mesto> VratiSvaMesta()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSvaMesta();
            } finally
            {
                broker.CloseConnection();
            }
        }
    }
}
