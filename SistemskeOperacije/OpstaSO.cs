using DatabaseBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        protected Broker broker = new Broker();

        public void Izvrsi()
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransakcion();

                IzvrsiKonkretnuOperaciju();

                broker.Commit();
            }
            catch (Exception es)
            {
                broker.Rollback();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        protected abstract void IzvrsiKonkretnuOperaciju();
    }
}
