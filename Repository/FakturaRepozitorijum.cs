using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FakturaRepozitorijum
    {
        Broker broker = new Broker();

        public void SacuvajFakturu(Faktura faktura)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransakcion();
                int idFakture = broker.SacuvajFakturu(faktura);

                foreach (StavkaFakture sf in faktura.Stavke)
                {
                    sf.FakturaId = idFakture;
                    broker.SacuvajStavkuFakture(sf);
                }
                broker.Commit();
            }
            catch (Exception es)
            {
                broker.Rollback();
                throw es;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Faktura> VratiSveFakture()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSveFakture();
            } finally
            {
                broker.CloseConnection();
            }
        }

        public List<Faktura> NadjiFakture(string kriterijum)
        {
            try
            {
                broker.OpenConnection();
                return broker.NadjiFakture(kriterijum);
            } finally
            {
                broker.CloseConnection();
            }
        }

        public void StornirajFakturu(Faktura faktura)
        {
            try
            {
                broker.OpenConnection();
                broker.StornirajFakturu(faktura);
            } finally
            {
                broker.CloseConnection();
            }
        }
    }
}
