using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Faktura
{
    public class ZapamtiFakturuSO : OpstaSO
    {
        private Domain.Faktura faktura;
        public ZapamtiFakturuSO(Domain.Faktura faktura)
        {
            this.faktura = faktura;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            int idFakture = repozitorijum.Sacuvaj(faktura);

            foreach (Domain.StavkaFakture sf in faktura.Stavke)
            {
                sf.FakturaId = idFakture;
                repozitorijum.Sacuvaj(sf);
            }
        }
    }
}
