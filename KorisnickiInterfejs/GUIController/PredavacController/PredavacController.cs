using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Predavac;
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

namespace KorisnickiInterfejs.GUIController.Predavac
{
    public class PredavacController
    {
        private UCPredavac predavac;
        private BindingList<Domain.Kurs> kursevi;

        public PredavacController(UCPredavac predavac)
        {
            this.predavac = predavac;
            kursevi = new BindingList<Domain.Kurs>();
        }

        public void Init()
        {
            try
            {
                predavac.CbKurs.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat< List<Domain.Kurs> >(Operacija.UcitajListuKurseva);
                predavac.CbKurs.DisplayMember = "Naziv";
                predavac.CbGender.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.Pol[]>(Operacija.UcitajSvePolove);
                predavac.DgvKursevi.DataSource = kursevi;
                predavac.DgvKursevi.Columns["KursId"].Visible = false;
            }
            catch (ServerCommunicationException es)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }
        
        private string ime = "";
        private string prezime = "";

        public void DaLiJeRec(TextBox t,bool daLiJeIme)
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

        private void OcistiKontrole()
        {
            predavac.LblDatumGreska.Text = "";
            predavac.LblNemaKurseva.Text = "";
            predavac.TxtFirstName.BackColor = Color.White;
            predavac.TxtLastName.BackColor = Color.White;
            predavac.TxtDateOfBirth.BackColor = Color.White;
            predavac.CbGender.BackColor = Color.White;
            predavac.CbKurs.BackColor = Color.White;
        }

        private void OcistiFormu()
        {
            kursevi = new BindingList<Domain.Kurs>();
            predavac.DgvKursevi.DataSource = kursevi;
            predavac.TxtDateOfBirth.Text = "";
            predavac.TxtFirstName.Text = "";
            predavac.TxtLastName.Text = "";
        }

        private bool Validacija()
        {
            OcistiKontrole();
            bool nijeDobro = false;
            if (!DateTime.TryParseExact(predavac.TxtDateOfBirth.Text, "dd.MM.yyyy.", null, System.Globalization.DateTimeStyles.None, out _))
            {
                predavac.TxtDateOfBirth.Text = "";
                predavac.LblDatumGreska.Text = "dd.MM.yyyy.";
                predavac.TxtDateOfBirth.BackColor = Color.Plum;
                nijeDobro = true;
            }

            Object pol = predavac.CbGender.SelectedItem;
            if (pol == null)
            {
                predavac.CbGender.BackColor = Color.Plum;
                nijeDobro = true;
            }

            if (string.IsNullOrEmpty(predavac.TxtFirstName.Text))
            {
                predavac.TxtFirstName.BackColor = Color.Plum;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(predavac.TxtLastName.Text))
            {
                predavac.TxtLastName.BackColor = Color.Plum;
                nijeDobro = true;
            }
            if (kursevi.Count == 0)
            {
                predavac.LblNemaKurseva.Text = "Niste dodali nijedan kurs!";
                nijeDobro = true;
            }

            return nijeDobro;
        }

        public void DodajPredavaca()
        {
            if (Validacija())
            {
                return;
            }

            Domain.Predavac p = new Domain.Predavac
            {
                DatumRodjenja = DateTime.ParseExact(predavac.TxtDateOfBirth.Text, "dd.MM.yyyy.", null),
                Ime = predavac.TxtFirstName.Text,
                Prezime = predavac.TxtLastName.Text,
                Pol = (Domain.Pol)predavac.CbGender.SelectedItem,
                ListaKurseva = kursevi.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiNovogPredavaca, p);
                MessageBox.Show("Uspesno sacuvan predavac!");
                OcistiFormu();
            }
            catch (ServerCommunicationException es)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }


        public void DodajKurs()
        {
            Domain.Kurs selektovani = (Domain.Kurs)predavac.CbKurs.SelectedItem;
            if (selektovani == null)
            {
                return;
            }

            if (kursevi.Contains(selektovani))
            {
                return;
            }

            kursevi.Add(selektovani);
            predavac.DgvKursevi.Refresh();
        }
    }
}
