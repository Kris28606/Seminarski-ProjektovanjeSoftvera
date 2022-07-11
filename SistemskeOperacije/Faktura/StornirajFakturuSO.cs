using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Faktura
{
    public class StornirajFakturuSO : OpstaSO
    {
        private Domain.Faktura faktura;
        public StornirajFakturuSO(Domain.Faktura faktura)
        {
            this.faktura = faktura;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            repozitorijum.Izmeni(faktura);
        }
    }
}
