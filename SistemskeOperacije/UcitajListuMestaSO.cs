using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UcitajListuMestaSO : OpstaSO
    {
        public List<Domain.Mesto> Rezultat { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = repozitorijum.VratiSve(new Domain.Mesto()).OfType<Domain.Mesto>().ToList();
        }
    }
}
