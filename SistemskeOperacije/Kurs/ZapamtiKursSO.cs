using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ZapamtiKursSO : OpstaSO
    {
        private Domain.Kurs kurs;
        public ZapamtiKursSO(Domain.Kurs k)
        {
            kurs = k;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            repozitorijum.Sacuvaj(kurs);
        }
    }
}
