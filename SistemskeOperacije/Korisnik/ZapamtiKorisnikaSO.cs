using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Korisnik
{
    public class ZapamtiKorisnikaSO : OpstaSO
    {
        private Domain.Korisnik korisnik;
        public ZapamtiKorisnikaSO(Domain.Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            int idKorisnika = repozitorijum.Sacuvaj(korisnik);

            foreach (Domain.Kurs kurs in korisnik.ListaKurseva)
            {
                //repozitorijum.SacuvajKursKorisnik(kurs, idKorisnika);
            }
        }
    }
}
