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
    public class PrikaziKursController
    {
        private FrmPrikaziKurs kurs;
        private Domain.Kurs trenutni;

        public PrikaziKursController(FrmPrikaziKurs frmPrikazi, Domain.Kurs trenutniKurs)
        {
            kurs = frmPrikazi;
            trenutni = trenutniKurs;
        }

        public void Init()
        {
            kurs.TxtName.Text = trenutni.Naziv;
            kurs.TxtPrice.Text = trenutni.Cena.ToString();
            kurs.TxtDate.Text = trenutni.DatumPocetka.ToString();
            kurs.TxtTime.Text = trenutni.Trajanje.ToString();
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
                    DateTime datum = DateTime.Parse(kurs.TxtDate.Text);
                }
                catch (Exception es)
                {
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

        private void OcistiKontrole()
        {
            kurs.TxtPrice.BackColor = Color.White;
            kurs.TxtName.BackColor = Color.White;
            kurs.TxtDate.BackColor = Color.White;
            kurs.TxtTime.BackColor = Color.White;
        }
    
        public void IzmeniKurs()
        {
            if (Validacija())
            {
                return;
            }

            Domain.Kurs k = new Domain.Kurs
            {
                KursId = trenutni.KursId,
                Naziv = kurs.TxtName.Text,
                Cena = Double.Parse(kurs.TxtPrice.Text),
                DatumPocetka = DateTime.Parse(kurs.TxtDate.Text),
                Trajanje = Int32.Parse(kurs.TxtTime.Text)
            };

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.IzmeniKurs, k);
                MessageBox.Show("Kurs je uspesno izmenjen!");
                kurs.DialogResult = DialogResult.OK;
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
    
        public void DaLiJeDouble()
        {
            try
            {
                Double.Parse(kurs.TxtPrice.Text);
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                kurs.TxtTime.Text = "";
            }
        }
    }

}
