using Common;
using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Faktura;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController.FakturaController
{
    public class FakturaController
    {
        private UCFaktura faktura;
        private BindingList<StavkaFakture> stavke;
        private Domain.Faktura trenutnaFaktura;
        public FakturaController(UCFaktura faktura)
        {
            this.faktura = faktura;
            stavke = new BindingList<StavkaFakture>();
            trenutnaFaktura= new Domain.Faktura();
        }

        public void Init()
        {
            try
            {
                faktura.CbNacinPlacanja.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.NacinPlacanja[]>(Operacija.UcitajSveNacinePlacanja);
                faktura.CbKorisnik.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika);
                faktura.CbKurs.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.NadjiKurseveZaKorisnika, (Domain.Korisnik)faktura.CbKorisnik.SelectedItem);
                faktura.CbKurs.DisplayMember = "Naziv";
                faktura.DgvStavkeFakture.DataSource = stavke;
                faktura.DgvStavkeFakture.Columns["FakturaId"].Visible = false;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
    
        public void PromeniCenuStavke()
        {
            Domain.Kurs k = (Domain.Kurs)faktura.CbKurs.SelectedItem;
            faktura.TxtVrednostStavke.Text = k.Cena.ToString();
        }

        public void DodajStavku()
        {
            faktura.CbKurs.BackColor = Color.White;
            Domain.Kurs selektovanKurs = (Domain.Kurs)faktura.CbKurs.SelectedItem;
            if (selektovanKurs == null)
            {
                faktura.CbKurs.BackColor = Color.LightPink;
                return;
            }

            StavkaFakture s = new StavkaFakture
            {
                Kurs = selektovanKurs,
                VrednostStavke = ((Domain.Kurs)faktura.CbKurs.SelectedItem).Cena,
                RedniBroj = stavke.Count() + 1
            };

            foreach (StavkaFakture sf in stavke)
            {
                if (sf.Kurs == selektovanKurs)
                {
                    return;
                }
            }

            stavke.Add(s);
            faktura.DgvStavkeFakture.Refresh();

            trenutnaFaktura.UkupnaCena += s.VrednostStavke;

            faktura.TxtUkupnaCena.Text = trenutnaFaktura.UkupnaCena.ToString();
        }
    
        public void SacuvajFakturu()
        {
            if (Validacija())
            {
                return;
            }

            Domain.Faktura novaFaktura = new Domain.Faktura
            {
                Datum = DateTime.ParseExact(faktura.TxtDatum.Text, "dd.MM.yyyy. HH:mm", null),
                Korisnik = (Domain.Korisnik)faktura.CbKorisnik.SelectedItem,
                NacinPlacanja = (NacinPlacanja)faktura.CbNacinPlacanja.SelectedItem,
                UkupnaCena = Double.Parse(faktura.TxtUkupnaCena.Text),
                Stavke = stavke.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiFakturu, novaFaktura);
                MessageBox.Show("Uspesno sacuvana faktura!");
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private bool Validacija()
        {
            OcistiKontrole();
            bool nijeDobro = false;
            Domain.Korisnik selektovaniKorisnik = (Domain.Korisnik)faktura.CbKorisnik.SelectedItem;
            if (selektovaniKorisnik == null)
            {
                faktura.CbKorisnik.BackColor = Color.LightPink;
                nijeDobro = true;
            }

            Object nacinPlacanja = faktura.CbNacinPlacanja.SelectedItem;
            if (nacinPlacanja == null)
            {
                faktura.CbNacinPlacanja.BackColor = Color.LightPink;
                nijeDobro = true;
            }
            if (!DateTime.TryParseExact(faktura.TxtDatum.Text, "dd.MM.yyyy. HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
            {
                faktura.TxtDatum.Text = "";
                faktura.LblDatumGreska.Text = "dd.MM.yyyy. HH:mm";
                faktura.TxtDatum.BackColor = Color.LightPink;
                nijeDobro = true;
            }
            if (stavke.Count == 0)
            {
                nijeDobro = true;
                faktura.LblGreska.Text = "Niste uneli nijednu stavku!";
            }
            return nijeDobro;
        }

        private void OcistiKontrole()
        {
            faktura.LblDatumGreska.Text = "";
            faktura.LblGreska.Text = "";
            faktura.CbKorisnik.BackColor = Color.White;
            faktura.CbNacinPlacanja.BackColor = Color.White;
            faktura.TxtDatum.BackColor = Color.White;
        }

        public void ObrisiStavku()
        {
            if (stavke.Count == 0)
            {
                return;
            }
            if (faktura.DgvStavkeFakture.SelectedRows.Count == 0)
            {
                faktura.LblNijeSelektovanaStavka.Text = "Niste selektovali nijednu stavku.";
                return;
            }

            StavkaFakture selektovana = (StavkaFakture)faktura.DgvStavkeFakture.SelectedRows[0].DataBoundItem;

            for (int i = selektovana.RedniBroj; i < stavke.Count; i++)
            {
                stavke[i].RedniBroj--;
            }
            faktura.LblNijeSelektovanaStavka.Text = "";
            stavke.Remove(selektovana);
            faktura.DgvStavkeFakture.Refresh();
        }

        public void PromeniKurseveZaKorisnika()
        {
            try
            {
                faktura.CbKurs.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.NadjiKurseveZaKorisnika, (Domain.Korisnik)faktura.CbKorisnik.SelectedItem);
                stavke = new BindingList<StavkaFakture>();
                faktura.DgvStavkeFakture.DataSource = stavke;
                faktura.TxtUkupnaCena.Text = "";
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

    }
}
