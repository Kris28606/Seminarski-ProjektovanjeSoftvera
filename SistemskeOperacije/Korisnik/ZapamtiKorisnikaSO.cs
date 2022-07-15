using Domain;
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
            korisnik.KorisnikId = idKorisnika;
            foreach (Domain.Kurs kurs in korisnik.ListaKurseva)
            {
                KursKorisnik kk = new KursKorisnik
                {
                    Korisnik=korisnik,
                    Kurs=kurs
                };
                repozitorijum.Sacuvaj(kk);
            }
        }
    }
}
