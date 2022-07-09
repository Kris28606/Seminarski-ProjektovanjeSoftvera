﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Korisnik
{
    public class NadjiKurseveZaKorisnikaSO : OpstaSO
    {
        private Domain.Korisnik korisnik;
        public List<Domain.Kurs> Rezultat { get; private set; }
        public NadjiKurseveZaKorisnikaSO(Domain.Korisnik korisnik)
        {
            this.korisnik = korisnik;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.VratiSveKurseveZaKorisnika(korisnik);
        }
    }
}
