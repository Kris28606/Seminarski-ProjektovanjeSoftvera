using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Faktura;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController.FakturaController
{
    public class PrikaziFakturuController
    {
        private FrmPrikaziFakturu faktura;
        private Domain.Faktura trenutna;
        public PrikaziFakturuController(FrmPrikaziFakturu ucFaktura, Domain.Faktura f)
        {
            this.faktura = ucFaktura;
            trenutna = f;
            Init();
        }

        private void Init()
        {
            faktura.CbKorisnik.Text = trenutna.Korisnik.Ime + " " + trenutna.Korisnik.Prezime;
            faktura.TxtDatum.Text = trenutna.Datum.ToString("dd.MM.yyyy. HH:mm");
            faktura.TxtStornirana.Text = trenutna.Stornirana.ToString();
            faktura.TxtUkupnaCena.Text = trenutna.UkupnaCena.ToString();
            faktura.CbNacinPlacanja.Text = trenutna.NacinPlacanja.ToString();
        }

        public void StornirajFakturu()
        {
            if (trenutna.Stornirana)
            {
                return;
            }

            trenutna.Stornirana = true;

            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.StornirajFakturu, trenutna);
                MessageBox.Show("Uspesno stornirana faktura!");
                faktura.DialogResult = DialogResult.OK;
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                faktura.DialogResult = DialogResult.OK;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void OK()
        {
            faktura.DialogResult = DialogResult.OK;
        }
    }
}
