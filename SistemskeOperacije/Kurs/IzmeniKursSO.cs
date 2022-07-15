using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class IzmeniKursSO : OpstaSO
    {
        private Domain.Kurs kurs;
        public bool Rezultat { get; private set; }
        public IzmeniKursSO(Domain.Kurs k)
        {
            kurs = k;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            if(repozitorijum.Izmeni(kurs)==0)
            {
                Rezultat = false;
                return;
            }
            Rezultat = true;
        }
    }
}
