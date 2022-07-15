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
    public class PrikaziPredavacaController
    {
        private FrmPrikaziPredavaca predavac;
        private Domain.Predavac trenutni;
        private BindingList<Domain.Kurs> kursevi;
        public PrikaziPredavacaController(FrmPrikaziPredavaca predavac, Domain.Predavac trenutni)
        {
            this.predavac = predavac;
            this.trenutni = trenutni;
        }

        public void Init()
        {
            try
            {
                predavac.TxtFirstName.Text = trenutni.Ime;
                predavac.TxtLastName.Text = trenutni.Prezime;
                predavac.TxtDateOfBirth.Text = trenutni.DatumRodjenja.ToString("dd.MM.yyyy.");
                predavac.CbGender.Text = trenutni.Pol.ToString();
                predavac.CbKurs.DataSource = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva);
                predavac.CbKurs.DisplayMember = "Naziv";
                kursevi = new BindingList<Domain.Kurs>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.NadjiKurseveZaPredavaca, trenutni));
                predavac.DgvKursevi.DataSource = kursevi;
                predavac.DgvKursevi.Columns["KursId"].Visible = false;
                predavac.DgvKursevi.Columns["NazivTabele"].Visible = false;
                predavac.DgvKursevi.Columns["Vrednosti"].Visible = false;
                predavac.DgvKursevi.Columns["Uslov"].Visible = false;
                predavac.DgvKursevi.Columns["Output"].Visible = false;
                predavac.DgvKursevi.Columns["Kriterijum"].Visible = false;
                predavac.DgvKursevi.Columns["JoinUslov"].Visible = false;
                predavac.DgvKursevi.Columns["UpdateUslov"].Visible = false;
            }
            catch (ServerCommunicationException)
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

        public void IzbaciKurs()
        {
            if (predavac.DgvKursevi.SelectedRows.Count == 0)
            {
                return;
            }

            Domain.Kurs selektovani = (Domain.Kurs)predavac.DgvKursevi.SelectedRows[0].DataBoundItem;

            kursevi.Remove(selektovani);
            predavac.DgvKursevi.Refresh();
        }

        public void DodajKurs()
        {
            Domain.Kurs selektovani = (Domain.Kurs)predavac.CbKurs.SelectedItem;

            if (selektovani==null || PostojiKurs(selektovani))
            {
                return;
            }

            kursevi.Add(selektovani);
            predavac.DgvKursevi.Refresh();
        }

        private bool PostojiKurs(Domain.Kurs selektovani)
        {
            foreach (Domain.Kurs k in kursevi)
            {
                if (k.KursId == selektovani.KursId && k.Naziv == selektovani.Naziv
                    && k.Cena == selektovani.Cena && k.DatumPocetka == selektovani.DatumPocetka
                    && k.Trajanje == selektovani.Trajanje)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Validacija()
        {
            predavac.TxtFirstName.BackColor = Color.White;
            predavac.TxtLastName.BackColor = Color.White;
            bool nijeDobro = false;
            if (string.IsNullOrEmpty(predavac.TxtFirstName.Text))
            {
                predavac.TxtFirstName.BackColor = Color.LightGreen;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(predavac.TxtLastName.Text))
            {
                predavac.TxtLastName.BackColor = Color.LightGreen;
                nijeDobro = true;
            }
            if(kursevi.Count==0)
            {
                nijeDobro = true;
            }
            return nijeDobro;
        }

        public void IzmeniPredavaca()
        {
            if (Validacija())
            {
                return;
            }

            Domain.Predavac p = new Domain.Predavac
            {
                Ime = predavac.TxtFirstName.Text,
                Prezime = predavac.TxtLastName.Text,
                PredavacId = trenutni.PredavacId,
                DatumRodjenja = trenutni.DatumRodjenja,
                Pol = trenutni.Pol,
                ListaKurseva = kursevi.ToList()
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniPredavaca, p);
                MessageBox.Show("Uspesno izmenjen predavac!");
                predavac.DialogResult = DialogResult.OK;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
                predavac.DialogResult = DialogResult.OK;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

    }
}
