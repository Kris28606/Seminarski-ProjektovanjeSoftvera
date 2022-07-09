using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PredavacRepozitorijum
    {
        Broker broker = new Broker();
        public List<Predavac> VratiSvePredavace()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSvePredavace();
            } finally
            {
                broker.CloseConnection();
            }
        }

        public void SacuvajPredavaca(Predavac p)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransakcion();

                int idPredavac = broker.SacuvajPredavaca(p);
                foreach (Kurs k in p.ListaKurseva)
                {
                    broker.SacuvajKursPredavac(k, idPredavac);
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

        public List<Predavac> NadjiPredavace(string kriterijum)
        {
            try
            {
                broker.OpenConnection();
                return broker.NadjiPredavace(kriterijum);
            } finally
            {
                broker.CloseConnection();
            }
        }

        public void IzmeniPredavaca(Predavac p)
        {
            try
            {
                broker.OpenConnection();
                broker.IzmeniPredavaca(p);

                broker.ObrisiKurseveZaPredavaca(p);
                foreach(Kurs k in p.ListaKurseva)
                {
                    broker.SacuvajKursPredavac(k,p.PredavacId);
                }
                broker.Commit();
            } catch(Exception es)
            {
                broker.Rollback();
                throw es;
            } finally
            {
                broker.CloseConnection();
            }
        }
    }
}
