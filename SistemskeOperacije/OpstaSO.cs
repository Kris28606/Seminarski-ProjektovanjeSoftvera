using Domain;
using Repository;
using Repository.GenerickiRepozitorijum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        protected IRepozitorijum<IOpstiObjekat> repozitorijum = new GenerickiRepozitorijum();
        public void Izvrsi()
        {
            try
            {
                repozitorijum.OtvoriKonekciju();
                repozitorijum.ZapocniTransakciju();

                IzvrsiKonkretnuOperaciju();

                repozitorijum.Commit();
            }
            catch (Exception es)
            {
                repozitorijum.RollBack();
                throw;
            }
            finally
            {
                repozitorijum.ZatvoriKonekciju();
            }
        }

        protected abstract void IzvrsiKonkretnuOperaciju();
    }
}
