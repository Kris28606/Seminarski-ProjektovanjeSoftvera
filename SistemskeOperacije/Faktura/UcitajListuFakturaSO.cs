using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Faktura
{
    public class UcitajListuFakturaSO : OpstaSO
    {
        public List<Domain.Faktura> Rezultat { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = repozitorijum.VratiSve(new Domain.Faktura()).OfType<Domain.Faktura>().ToList();
        }
    }
}
