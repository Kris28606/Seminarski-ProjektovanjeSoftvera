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

        public ObrisiKorisnikaSO(Domain.Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            broker.ObrisiKorisnika(korisnik);
        }
    }
}
