using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Korisnik
{
    public class UcitajKorisnikaSO : OpstaSO
    {
        private Domain.Korisnik korisnik;
        public Domain.Korisnik Rezultat { get; set; }
        public UcitajKorisnikaSO(Domain.Korisnik k)
        {
            korisnik = k;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = (Domain.Korisnik)repozitorijum.VratiJedan(korisnik);
        }
    }
}
