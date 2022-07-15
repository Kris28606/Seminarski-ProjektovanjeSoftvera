using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Korisnik
{
    public class ObrisiKorisnikaSO : OpstaSO
    {
        private Domain.Korisnik korisnik;
        public bool Rezultat { get; private set; }

        public ObrisiKorisnikaSO(Domain.Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            KursKorisnik kk = new KursKorisnik
            {
                Korisnik = korisnik
            };
            repozitorijum.Izbrisi(kk);
            if (repozitorijum.Izbrisi(korisnik) == 0)
            {
                Rezultat = false;
                return;
            }
            Rezultat = true;
        }
    }
}
