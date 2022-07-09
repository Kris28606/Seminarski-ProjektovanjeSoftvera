using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class KursRepozitorijum
    {
        Broker broker = new Broker();

        public void DodajKurs(Kurs k)
        {
            try
            {
                broker.OpenConnection();
                broker.DodajKurs(k);
            } finally
            {
                broker.CloseConnection();
            }
        }

        public List<Kurs> VratiSveKurseve()
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSveKurseve();

            } finally
            {
                broker.CloseConnection();
            }
        }

        public void IzmeniKurs(Kurs k)
        {
            try
            {
                broker.OpenConnection();
                broker.IzmeniKurs(k);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Kurs> VratiSveKurseveZaKorisnika(Korisnik korisnik)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSveKurseveZaKorisnika(korisnik);
            } finally
            {
                broker.CloseConnection();
            }
        }

        public List<Kurs> VratiSveKurseveZaPredavaca(Predavac p)
        {
            try
            {
                broker.OpenConnection();
                return broker.VratiSveKurseveZaPredavaca(p);
            } finally
            {
                broker.CloseConnection();
            }
        }

        public List<Kurs> NadjiKurseve(string kriterijum)
        {
            try
            {
                broker.OpenConnection();
                return broker.NadjiKurseve(kriterijum);
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
