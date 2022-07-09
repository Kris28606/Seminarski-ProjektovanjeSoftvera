using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class KorisnikRepozitorijum
    {
        Broker broker = new Broker();
        public List<Korisnik> VratiSveKorisnike()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSveKorisnike();
            } finally
            {
                broker.CloseConnection();
            }
        }

        public void SacuvajKorisnika(Korisnik k)
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransakcion();
                int idKorisnika = broker.SacuvajKorisnika(k);

                foreach (Kurs kurs in k.ListaKurseva)
                {
                    broker.SacuvajKursKorisnik(kurs,idKorisnika);
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

        public List<Korisnik> NadjiKorisnika(string kriterijum)
        {
            try
            {
                broker.OpenConnection();
                return broker.NadjiKorisnike(kriterijum);
            } finally
            {
                broker.CloseConnection();
            }
        }

        public void ObrisiKorisnika(Korisnik korisnik)
        {
            try
            {
                broker.OpenConnection();
                broker.ObrisiKorisnika(korisnik);
            }finally
            {
                broker.CloseConnection();
            }
        }
    }
}
