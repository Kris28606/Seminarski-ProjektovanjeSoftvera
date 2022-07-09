using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Korisnik
{
    public class NadjiKorisnikeSO : OpstaSO
    {
        private string kriterijum;
        public List<Domain.Korisnik> Rezultat { get; private set; }
        public NadjiKorisnikeSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.NadjiKorisnike(kriterijum);
        }
    }
}
