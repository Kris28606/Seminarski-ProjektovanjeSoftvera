using ApplicationLogic;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
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
            this.klijentSoket = klijentSoket;
            helper = new CommunicationHelper(klijentSoket);
        }

        public void ObradiZahteve()
        {
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
                Debug.WriteLine(">>>>>> Klijent zatvorio formu: " + ex.Message);
            } finally
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(klijentSoket!=null)
            {
                klijentSoket.Shutdown(SocketShutdown.Both);
                klijentSoket.Dispose();
                klijentSoket = null;
                Debug.WriteLine(">>>> Ugasen klijentski soket.");
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
                    try
                    {
                        Controller.Instance.DodajKurs((Kurs)zahtev.ZahtevObjekat);
                    }
                    catch (SqlException)
                    {
                        odgovor.Poruka = "Sistem ne moze da zapamti kurs!";
                        odgovor.UspesnaOperacija = false;
                    }
                    break;

                case Operacija.IzmeniKurs:
                    try
                    {
                        if(!Controller.Instance.IzmeniKurs((Kurs)zahtev.ZahtevObjekat))
                        {
                            odgovor.UspesnaOperacija = false;
                            odgovor.Poruka = "Sistem ne moze da izmeni kurs!";
                        }
                        
                    } catch(SqlException)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da izmeni kurs!";
                    }
                    break;

                case Operacija.NadjiKurseve:
                    List<Kurs> pronadjeniKursevi = Controller.Instance.NadjiKurseve((string)zahtev.ZahtevObjekat);
                    if(pronadjeniKursevi.Count==0)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje kurseve!";
                    } else
                    {
                        odgovor.OdgovorObjekat = pronadjeniKursevi;
                    }
                    break;

                case Operacija.UcitajListuKurseva:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveKurseve();
                    break;

                case Operacija.ZapamtiNovogPredavaca:
                    try
                    {
                        Controller.Instance.SacuvajPredavaca((Predavac)zahtev.ZahtevObjekat);
                    } catch(SqlException)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da sacuva predavaca!";
                    }
                    break;

                case Operacija.IzmeniPredavaca:
                    try
                    {
                        if(!Controller.Instance.IzmeniPredavaca((Predavac)zahtev.ZahtevObjekat))
                        {
                            odgovor.UspesnaOperacija = false;
                            odgovor.Poruka = "Sistem ne moze da izmeni predavaca!";
                        }
                        
                    } catch(SqlException)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da izmeni predavaca!";
                    }
                    break;

                case Operacija.NadjiPredavace:
                    List<Predavac> pronadjeniPred = Controller.Instance.NadjiPredavace((string)zahtev.ZahtevObjekat);
                    if (pronadjeniPred.Count == 0)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje predavace!";
                    }
                    else
                    {
                        odgovor.OdgovorObjekat = pronadjeniPred;
                    }
                    break;

                case Operacija.UcitajListuMesta:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSvaMesta();
                    break;

                case Operacija.ZapamtiKorisnika:
                    try
                    {
                        Controller.Instance.SacuvajKorisnika((Korisnik)zahtev.ZahtevObjekat);
                    }
                    catch (SqlException)
                    {
                        odgovor.Poruka = "Sistem ne moze da zapamti korisnika!";
                        odgovor.UspesnaOperacija = false;
                    }
                    break;

                case Operacija.NadjiKorisnike:
                    List<Korisnik> pronadjeniKorisnici = Controller.Instance.NadjiKorisnika((string)zahtev.ZahtevObjekat);
                    if (pronadjeniKorisnici.Count == 0)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje korisnike!";
                    }
                    else
                    {
                        odgovor.OdgovorObjekat = pronadjeniKorisnici;
                    }
                    break;

                case Operacija.ObrisiKorisnika:
                    try
                    {
                        if (!Controller.Instance.ObrisiKorisnika((Korisnik)zahtev.ZahtevObjekat))
                        {
                            odgovor.Poruka = "Sistem ne moze da obrise korisnika!";
                            odgovor.UspesnaOperacija = false;
                        }
                    }
                    catch (SqlException)
                    {
                        odgovor.Poruka = "Sistem ne moze da obrise korisnika!";
                        odgovor.UspesnaOperacija = false;
                    }
                    break;

                case Operacija.UcitajListuKorisnika:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveKorisnike();
                    break;

                case Operacija.ZapamtiFakturu:
                    try
                    {
                        Controller.Instance.SacuvajFakturu((Faktura)zahtev.ZahtevObjekat);
                    }
                    catch (SqlException)
                    {
                        odgovor.Poruka = "Sistem ne moze da sacuva fakturu!";
                        odgovor.UspesnaOperacija = false;
                    }
                    break;

                case Operacija.NadjiFakture:
                    List<Faktura> pronadjeneFakture = Controller.Instance.NadjiFakture((string)zahtev.ZahtevObjekat);
                    if (pronadjeneFakture.Count == 0)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da pronadje fakture!";
                    }
                    else
                    {
                        odgovor.OdgovorObjekat = pronadjeneFakture;
                    }
                    break;

                case Operacija.StornirajFakturu:
                    if(!Controller.Instance.StornirajFakturu((Faktura)zahtev.ZahtevObjekat))
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da stornira fakturu!";
                    }
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

                case Operacija.UcitajSvePolove:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSvePolove();
                    break;

                case Operacija.UcitajSveNacinePlacanja:
                    odgovor.OdgovorObjekat = Controller.Instance.VratiSveNacinePlacanja();
                    break;

                case Operacija.UcitajKurs:
                    odgovor.OdgovorObjekat = Controller.Instance.UcitajKurs((Kurs)zahtev.ZahtevObjekat);
                    if(odgovor.OdgovorObjekat==null)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da ucita kurs!";
                    }
                    break;
                case Operacija.UcitajPredavaca:
                    odgovor.OdgovorObjekat = Controller.Instance.UcitajPredavaca((Predavac)zahtev.ZahtevObjekat);
                    if (odgovor.OdgovorObjekat == null)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da ucita predavaca!";
                    }
                    break;

                case Operacija.UcitajKorisnika:
                    odgovor.OdgovorObjekat = Controller.Instance.UcitajKorisnika((Korisnik)zahtev.ZahtevObjekat);
                    if (odgovor.OdgovorObjekat == null)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da ucita korisnika!";
                    }
                    break;

                case Operacija.UcitajFakturu:
                    odgovor.OdgovorObjekat = Controller.Instance.UcitajFakturu((Faktura)zahtev.ZahtevObjekat);
                    if (odgovor.OdgovorObjekat == null)
                    {
                        odgovor.UspesnaOperacija = false;
                        odgovor.Poruka = "Sistem ne moze da ucita fakturu!";
                    }
                    break;
            }
            return odgovor;
        }

    }
}
