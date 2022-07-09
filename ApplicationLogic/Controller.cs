using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;
        UserRepozitorijum userRepozitorijum;
        KursRepozitorijum kursRepozitorijum;
        PredavacRepozitorijum predavacRepozitorijum;
        FakturaRepozitorijum fakturaRepozitorijum;
        KorisnikRepozitorijum korisnikRepozitorijum;
        MestoRepozitorijum mestoRepozitorijum;

        public List<Faktura> VratiSvefakture()
        {
            return fakturaRepozitorijum.VratiSveFakture();
        }

        public User PrijavljeniKorisnik { get; private set; }

        public Array VratiSveNacinePlacanja()
        {
            return Enum.GetValues(typeof(Domain.NacinPlacanja));
        }

        public List<Kurs> VratiSveKurseve()
        {
            return kursRepozitorijum.VratiSveKurseve();
        }

        public Array VratiSvePolove()
        {
            return Enum.GetValues(typeof(Domain.Pol));
        }

        public List<Faktura> NadjiFakture(string kriterijum)
        {
            return fakturaRepozitorijum.NadjiFakture(kriterijum);
        }

        public List<Kurs> VratiSveKurseveZaPredavaca(Predavac p)
        {
            return kursRepozitorijum.VratiSveKurseveZaPredavaca(p);
        }

        public List<Korisnik> VratiSveKorisnike()
        {
            return korisnikRepozitorijum.VratiSveKorisnike();
        }

        public void ObrisiKorisnika(Korisnik korisnik)
        {
            korisnikRepozitorijum.ObrisiKorisnika(korisnik);
        }

        public List<Korisnik> NadjiKorisnika(string kriterijum)
        {
            return korisnikRepozitorijum.NadjiKorisnika(kriterijum);   
        }

        public List<Mesto> VratiSvaMesta()
        {
            return mestoRepozitorijum.VratiSvaMesta();
        }

        public List<Kurs> VratiSveKurseveZaKorisnika(Korisnik korisnik)
        {
            return kursRepozitorijum.VratiSveKurseveZaKorisnika(korisnik);
        }

        public void StornirajFakturu(Faktura faktura)
        {
            fakturaRepozitorijum.StornirajFakturu(faktura);
        }

        private Controller()
        {
            userRepozitorijum = new UserRepozitorijum();
            kursRepozitorijum = new KursRepozitorijum();
            predavacRepozitorijum = new PredavacRepozitorijum();
            fakturaRepozitorijum = new FakturaRepozitorijum();
            korisnikRepozitorijum = new KorisnikRepozitorijum();
            mestoRepozitorijum = new MestoRepozitorijum();
        }

        public List<Predavac> NadjiPredavace(string kriterijum)
        {
            return predavacRepozitorijum.NadjiPredavace(kriterijum);
        }

        public void SacuvajKorisnika(Korisnik k)
        {
            korisnikRepozitorijum.SacuvajKorisnika(k);
        }

        public static Controller Instance { 

            get { 
                if(instance == null)
                {
                    instance = new Controller(); 
                }
                return instance; 
            } 
        }

        public List<Predavac> VratiSvePredavace()
        {
            return predavacRepozitorijum.VratiSvePredavace();
        }

        public List<Kurs> NadjiKurseve(string kriterijum)
        {
            return kursRepozitorijum.NadjiKurseve(kriterijum);
        }

        public User LogIn(User user)
        {
            user = userRepozitorijum.LogIn(user);
            if(user!=null)
            {
                PrijavljeniKorisnik = user;
                return user;
            }
            return null;
        }

        public void DodajKurs(Kurs k)
        {
            kursRepozitorijum.DodajKurs(k);
        }

        public void IzmeniKurs(Kurs k)
        {
            kursRepozitorijum.IzmeniKurs(k);
        }

        public void SacuvajFakturu(Faktura faktura)
        {
            fakturaRepozitorijum.SacuvajFakturu(faktura);
        }

        public void SacuvajPredavaca(Predavac p)
        {
            predavacRepozitorijum.SacuvajPredavaca(p);
        }

        public void IzmeniPredavaca(Predavac p)
        {
            predavacRepozitorijum.IzmeniPredavaca(p);
        }
    }
}
