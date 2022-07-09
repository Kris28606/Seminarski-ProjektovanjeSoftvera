using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class ZapamtiPredavacaSO : OpstaSO
    {
        private Domain.Predavac predavac;
        public ZapamtiPredavacaSO(Domain.Predavac p)
        {
            predavac = p;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            int idPredavac = broker.SacuvajPredavaca(predavac);
            foreach (Domain.Kurs k in predavac.ListaKurseva)
            {
                broker.SacuvajKursPredavac(k, idPredavac);
            }
        }
    }
}
