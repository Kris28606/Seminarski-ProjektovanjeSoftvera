using Domain;
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
            repozitorijum.Izmeni(predavac);
            KursPredavac kp = new KursPredavac
            {
                Predavac = predavac
            };
            repozitorijum.Izbrisi(kp);

            foreach (Domain.Kurs k in predavac.ListaKurseva)
            {
                kp.Kurs = k;
                repozitorijum.Sacuvaj(kp);
            }
        }
    }
}
