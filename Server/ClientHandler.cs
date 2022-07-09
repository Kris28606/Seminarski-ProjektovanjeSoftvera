using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket klijentSoket;
        private bool kraj = false;
        private CommunicationHelper helper;

        public ClientHandler(Socket klijentSoket)
        {
            //vezan samo za jednog klijenta
            this.klijentSoket = klijentSoket;
            helper = new CommunicationHelper(klijentSoket);
        }

        public void ObradiZahteve()
        {
            bool kraj = false;
            try
            {
                while (!kraj)
                {
                    Zahtev zahtev = helper.Primi<Zahtev>();
                    Odgovor odgovor;
                    try
                    {
                        odgovor = KreirajOdgovor(zahtev);
                    } catch(Exception ex)
                    {
                        odgovor = new Odgovor();
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = ex.Message;
                    }
                    helper.Posalji(odgovor);
                }
            }
            catch (IOException ex)
            {
                //klijent zatvorio svoju formu
                Debug.WriteLine(">>>>>> " + ex.Message);
            } finally
            {
                Stop();
                // ako stavim ovo dole u case bacice mi ovaj exception gore jer cu pokusati
                // da serijalizujem poruku a soket je disposovan
            }
        }

        public void Stop()
        {
            if(klijentSoket!=null)
            {
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Dispose();
                klijentSoket = null;
            }
        }

        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            switch (zahtev.Operacija)
            {
                case Operacija.Prijava:
                    odgovor.OdgovorObjekat = Controller.Instance.LogIn((User)zahtev.ZahtevObjekat);
                    if (odgovor.OdgovorObjekat == null)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Korisnik ne postoji!";
                    }
                    break;

                case Operacija.ZapamtiNoviKurs:
                    Controller.Instance.DodajKurs((Kurs)zahtev.ZahtevObjekat);
                    odgovor.Poruka = "Kurs je uspesno sacuvan!";
                    break;

                case Operacija.IzmeniKurs:
                    Controller.Instance.IzmeniKurs((Kurs)zahtev.ZahtevObjekat);
                    break;

                case Operacija.NadjiKurseve:
                    odgovor.OdgovorObjekat=Controller.Instance.NadjiKurseve((string)zahtev.ZahtevObjekat);
                    break;

                case Operacija.UcitajListuKurseva:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveKurseve();
                    break;

                case Operacija.ZapamtiNovogPredavaca:
                    Controller.Instance.SacuvajPredavaca((Predavac)zahtev.ZahtevObjekat);
                    break;

                case Operacija.IzmeniPredavaca:
                    Controller.Instance.IzmeniPredavaca((Predavac)zahtev.ZahtevObjekat);
                    break;

                case Operacija.NadjiPredavace:
                    odgovor.OdgovorObjekat=Controller.Instance.NadjiPredavace((string)zahtev.ZahtevObjekat);
                    break;

                case Operacija.UcitajListuMesta:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSvaMesta();
                    break;

                case Operacija.ZapamtiKorisnika:
                    Controller.Instance.SacuvajKorisnika((Korisnik)zahtev.ZahtevObjekat);
                    break;

                case Operacija.NadjiKorisnike:
                    odgovor.OdgovorObjekat = Controller.Instance.NadjiKorisnika((string)zahtev.ZahtevObjekat);
                    break;

                case Operacija.ObrisiKorisnika:
                    Controller.Instance.ObrisiKorisnika((Korisnik)zahtev.ZahtevObjekat);
                    break;

                case Operacija.UcitajListuKorisnika:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveKorisnike();
                    break;

                case Operacija.ZapamtiFakturu:
                    Controller.Instance.SacuvajFakturu((Faktura)zahtev.ZahtevObjekat);
                    break;

                case Operacija.NadjiFakture:
                    odgovor.OdgovorObjekat = Controller.Instance.NadjiFakture((string)zahtev.ZahtevObjekat);
                    break;

                case Operacija.StornirajFakturu:
                    Controller.Instance.StornirajFakturu((Faktura)zahtev.ZahtevObjekat);
                    break;

                case Operacija.Kraj:
                    kraj = true;
                    break;

                case Operacija.UcitajListuPredavaca:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSvePredavace();
                    break;

                case Operacija.NadjiKurseveZaPredavaca:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveKurseveZaPredavaca((Predavac)zahtev.ZahtevObjekat);
                    break;

                case Operacija.NadjiKurseveZaKorisnika:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveKurseveZaKorisnika((Korisnik)zahtev.ZahtevObjekat);
                    break;

                case Operacija.UcitajListuFaktura:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSvefakture();
                    break;
            }
            return odgovor;
        }

    }
}
