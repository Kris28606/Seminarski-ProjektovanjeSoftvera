using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Kurs;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class KursController
    {
        private UCKurs kurs;
        public KursController(UCKurs kurs)
        {
            this.kurs = kurs;
        }

        private void OcistiKontrole()
        {
            kurs.TxtPrice.BackColor = Color.White;
            kurs.TxtName.BackColor = Color.White;
            kurs.TxtDate.BackColor = Color.White;
            kurs.TxtTime.BackColor = Color.White;
        }

        private bool Validacija()
        {
            OcistiKontrole();
            bool nijeDobro = false;
            if (string.IsNullOrEmpty(kurs.TxtName.Text))
            {
                kurs.TxtName.BackColor = Color.LightBlue;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(kurs.TxtPrice.Text))
            {
                kurs.TxtPrice.BackColor = Color.LightBlue;
                nijeDobro = true;
            }
            if (string.IsNullOrEmpty(kurs.TxtDate.Text))
            {
                kurs.TxtDate.BackColor = Color.LightBlue;
                nijeDobro = true;
            }
            else
            {
                try
                {
                    DateTime datum = DateTime.ParseExact(kurs.TxtDate.Text, "dd.MM.yyyy. HH:mm", null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Datum mora biti u formatu dd.MM.yyyy. HH:mm !");
                    kurs.TxtDate.BackColor = Color.SkyBlue;
                    kurs.TxtDate.Text = "";
                    nijeDobro = true;
                }
            }
            if (string.IsNullOrEmpty(kurs.TxtTime.Text))
            {
                kurs.TxtTime.BackColor = Color.LightBlue;
                nijeDobro = true;
            }

            return nijeDobro;
        }

        private void OcistiFormu()
        {
            kurs.TxtPrice.Text = "";
            kurs.TxtName.Text = "";
            kurs.TxtDate.Text = "";
            kurs.TxtTime.Text = "";
        }

        public void DodajKurs()
        {
            if (Validacija())
            {
                return;
            }

            Domain.Kurs k = new Domain.Kurs
            {
                Naziv = kurs.TxtName.Text,
                Cena = Double.Parse(kurs.TxtPrice.Text),
                DatumPocetka = DateTime.ParseExact(kurs.TxtDate.Text, "dd.MM.yyyy. HH:mm", null),
                Trajanje = Int32.Parse(kurs.TxtTime.Text)
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ZapamtiNoviKurs, k);
                MessageBox.Show("Kurs je uspesno sacuvan!");
                OcistiFormu();
            } catch(ServerCommunicationException)
            {
                throw;
            } 
            catch(SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                OcistiFormu();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        public void DaLiJeDouble()
        {
            try
            {
                Double.Parse(kurs.TxtPrice.Text);
            }
            catch (Exception)
            {
                kurs.TxtPrice.Text = "";
            }
        }

        public void DaLiJeInt()
        {
            try
            {
                Int32.Parse(kurs.TxtTime.Text);
            }
            catch (Exception)
            {
                kurs.TxtTime.Text = "";
            }
        }

    }
}

