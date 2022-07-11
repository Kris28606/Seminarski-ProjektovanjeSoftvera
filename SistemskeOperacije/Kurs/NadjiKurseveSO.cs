using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SistemskeOperacije.Kurs
{
    public class NadjiKurseveSO : OpstaSO
    {
        private string kriterijum;

        public List<Domain.Kurs> Rezultat { get; private set; }
        public NadjiKurseveSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = repozitorijum.Pretraga(new Domain.Kurs(), kriterijum).OfType<Domain.Kurs>().ToList();
        }
    }
}
