using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Korisnik
{
    public class UcitajListuKorisnikaSO : OpstaSO
    {
        public List<Domain.Korisnik> Rezultat { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = repozitorijum.VratiSve(new Domain.Korisnik()).OfType<Domain.Korisnik>().ToList();
        }
    }
}
