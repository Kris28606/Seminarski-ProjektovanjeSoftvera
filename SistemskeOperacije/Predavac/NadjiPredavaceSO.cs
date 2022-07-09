using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class NadjiPredavaceSO : OpstaSO
    {
        private string kriterijum;
        public List<Domain.Predavac> Rezultat { get; private set; }
        public NadjiPredavaceSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = broker.NadjiPredavace(kriterijum);
        }
    }
}
