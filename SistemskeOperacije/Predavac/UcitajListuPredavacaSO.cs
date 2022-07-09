using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Predavac
{
    public class UcitajListuPredavacaSO : OpstaSO
    {
        public List<Domain.Predavac> Rezultat { get; private set; }
        protected override void IzvrsiKonkretnuOperaciju()
        {
            throw new NotImplementedException();
        }
    }
}
