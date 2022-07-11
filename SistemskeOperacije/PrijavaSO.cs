using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrijavaSO : OpstaSO
    {
        private User user;
        public User Rezultat { get; private set; }

        public PrijavaSO(User u)
        {
            user = u;
        }

        protected override void IzvrsiKonkretnuOperaciju()
        {
            Rezultat = (User)repozitorijum.VratiJedan(user);
        }
    }
}
