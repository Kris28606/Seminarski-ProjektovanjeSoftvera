using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class IzmeniPredavacaSO : OpstaSO
    {
        private Domain.Predavac predavac;
        public IzmeniPredavacaSO(Domain.Predavac p)
        {
            predavac = p;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            broker.IzmeniPredavaca(predavac);
            broker.ObrisiKurseveZaPredavaca(predavac);
            foreach (Domain.Kurs k in predavac.ListaKurseva)
            {
                broker.SacuvajKursPredavac(k, predavac.PredavacId);
            }
        }
    }
}
