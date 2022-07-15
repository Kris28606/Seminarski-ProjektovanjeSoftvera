using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class KorisnikController
    {
        private UCKorisnik korisnik;
        private BindingList<Domain.Kurs> kursevi;
        public KorisnikController(UCKorisnik korisnik)
        {
            this.korisnik = korisnik;
            kursevi = new BindingList<Domain.Kurs>();
            Init();
        }

        private void Init()
        {
            try
            {
                korisnik.DgvKursevi.DataSource = kursevi;
                korisnik.DgvKursevi.Columns["KursId"].Visible = false;
                korisnik.DgvKursevi.Columns["NazivTabele"].Visible = false;
                korisnik.DgvKursevi.Columns["Vrednosti"].Visible = false;
                korisnik.DgvKursevi.Columns["Uslov"].Visible = false;
                korisnik.DgvKursevi.Columns["Output"].Visible = false;
                korisnik.DgvKursevi.Columns["Kriterijum"].Visible = false;
                korisnik.DgvKursevi.Columns["JoinUslov"].Visible = false;
                korisnik.DgvKursevi.Columns["UpdateUslov"].Visible = false;
                korisnik.LblKursGreska.ForeColor = Color.Red;
                korisnik.CbKurs.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva);
                korisnik.CbMesto.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Mesto>>(Operacija.UcitajListuMesta);
                korisnik.CbMesto.DisplayMember = "Naziv";
            }
            catch (ServerCommunicationException)
            {
                throw;
            } catch(SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            } catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        internal void IzbaciKurs()
        {
            if(kursevi.Count==0)
            {
                return;
            }
            if(korisnik.DgvKursevi.SelectedRows.Count==0)
            {
                korisnik.LblKursGreska.Text = "Niste selektovali nijedan kurs!";
                return;
            }

            Domain.Kurs selektovani = (Domain.Kurs)korisnik.DgvKursevi.SelectedRows[0].DataBoundItem;
            kursevi.Remove(selektovani);
            korisnik.LblKursGreska.Text = "";
            korisnik.DgvKursevi.Refresh();
        }

        private void OcistiFormu()
        {
            korisnik.TxtFirsName.Text = "";
            korisnik.TxtLastName.Text = "";
            korisnik.TxtAdrress.Text = "";
            korisnik.TxtContact.Text = "";
            korisnik.LblKursGreska.Text = "";
            kursevi = new BindingList<Domain.Kurs>();
            korisnik.DgvKursevi.DataSource = kursevi;
        }

        private string ime = "";
        private string prezime = "";

        public void DaLiJeRec(TextBox t, bool daLiJeIme)
        {
            bool okej = Regex.IsMatch(t.Text, @"^[a-zA-Z]*$");
            if (!okej)
            {
                if (daLiJeIme)
                {
                    t.Text = ime;
                }
                else
                {
                    t.Text = prezime;
                }
            }
            else
            {
                if (daLiJeIme)
                {
                    ime = t.Text;
                }
                else
                {
                    prezime = t.Text;
                }
            }
        }
    
        public void DaliJeBroj()
        {
            bool okej = Regex.IsMatch(korisnik.TxtContact.Text, @"^[0-9]*$");
            if (!okej)
            {
                korisnik.TxtContact.Text = "";
            }
        }

        private bool Validacija()
        {
            OcistiKontrole();

            bool nijeDobro = false;

            if (string.IsNullOrEmpty(korisnik.TxtFirsName.Text))
            {
                korisnik.TxtFirsName.BackColor = Color.LightCoral;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(korisnik.TxtLastName.Text))
            {
                korisnik.TxtLastName.BackColor = Color.LightCoral;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(korisnik.TxtContact.Text))
            {
                korisnik.TxtContact.BackColor = Color.LightCoral;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(korisnik.TxtAdrress.Text))
            {
                korisnik.TxtAdrress.BackColor = Color.LightCoral;
                nijeDobro = true;
            }
            Domain.Kurs selektovaniKurs = (Domain.Kurs)korisnik.CbKurs.SelectedItem;
            if (selektovaniKurs == null)
            {
                korisnik.CbKurs.BackColor = Color.LightCoral;
                nijeDobro = true;
            }
            Domain.Mesto selektovanoMesto = (Domain.Mesto)korisnik.CbMesto.SelectedItem;
            if (selektovanoMesto == null)
            {
                korisnik.CbMesto.BackColor = Color.LightCoral;
                nijeDobro = true;
            }
            if(kursevi.Count==0)
            {
                korisnik.LblKursGreska.Text = "Niste dodali nijedan kurs!";
                nijeDobro = true;
            }
            return nijeDobro;

        }

        private void OcistiKontrole()
        {
            korisnik.TxtLastName.BackColor = Color.White;
            korisnik.TxtFirsName.BackColor = Color.White;
            korisnik.TxtAdrress.BackColor = Color.White;
            korisnik.TxtContact.BackColor = Color.White;
            korisnik.LblKursGreska.Text = "";
        }

        public void DodajKurs()
        {
            korisnik.CbKurs.BackColor = Color.White;
            Domain.Kurs dodatiKurs = (Domain.Kurs)korisnik.CbKurs.SelectedItem;
            if (dodatiKurs == null)
            {
                korisnik.CbKurs.BackColor = Color.LightPink;
                return;
            }
            if (kursevi.Contains(dodatiKurs))
            {
                return;
            }
            kursevi.Add(dodatiKurs);
            korisnik.DgvKursevi.Refresh();
        }

        public void DodajKorisnika()
        {
            if (Validacija())
            {
                return;
            }

            Domain.Korisnik k = new Domain.Korisnik
            {
                Ime = korisnik.TxtFirsName.Text,
                Prezime = korisnik.TxtLastName.Text,
                Adresa = korisnik.TxtAdrress.Text,
                Mesto = (Domain.Mesto)korisnik.CbMesto.SelectedItem,
                Kontakt = korisnik.TxtContact.Text,
                ListaKurseva = kursevi.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiKorisnika, k);
                MessageBox.Show("Uspesno sacuvan korisnik!");
                OcistiFormu();
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
