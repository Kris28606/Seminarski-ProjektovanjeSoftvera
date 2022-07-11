using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class NadjiKurseveZaPredavacaSO : OpstaSO
    {
        private Domain.Predavac predavac;
        public List<Domain.Kurs> Rezultat { get; private set; }
        public NadjiKurseveZaPredavacaSO(Domain.Predavac p)
        {
            predavac = p;
        }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            KursPredavac kp = new KursPredavac { 
                Predavac= predavac,
            };

            Rezultat = repozitorijum.VratiSveZaNekog(kp).OfType<Domain.Kurs>().ToList();
        }
    }
}
