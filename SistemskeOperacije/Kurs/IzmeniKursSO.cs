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
        public IzmeniKursSO(Domain.Kurs k)
        {
            kurs = k;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            repozitorijum.Izmeni(kurs);
        }
    }
}
