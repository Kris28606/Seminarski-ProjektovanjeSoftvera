using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Faktura
{
    public class NadjiFaktureSO : OpstaSO
    {
        private string kriterijum;
        public List<Domain.Faktura> Rezultat { get; private set; }
        public NadjiFaktureSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = repozitorijum.Pretraga(new Domain.Faktura(), kriterijum).OfType<Domain.Faktura>().ToList();
        }
    }
}
