using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Faktura
{
    public class UcitajFakturuSO : OpstaSO
    {
        public Domain.Faktura Rezultat { get; private set; }
        private Domain.Faktura faktura;

        public UcitajFakturuSO(Domain.Faktura f)
        {
            this.faktura = f;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = (Domain.Faktura)repozitorijum.VratiJedan(faktura);
        }
    }
}
