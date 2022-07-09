using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Faktura;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController.FakturaController
{
    public class SveFaktureController
    {
        private UCSveFakture ucFakture;
        private BindingList<Domain.Faktura> fakture;
        public SveFaktureController(UCSveFakture fakture)
        {
            this.ucFakture = fakture;
            Init();
        }

        private void Init()
        {
            fakture = new BindingList<Domain.Faktura>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.UcitajListuFaktura));
            ucFakture.DgvFakture.DataSource = fakture;
            ucFakture.DgvFakture.Columns["FakturaId"].Visible = false;
        }

        public void NadjiFakturu()
        {
            if (ucFakture.TxtPretraga.Text == "" || ucFakture.TxtPretraga.Text == " ")
            {
                return;
            }
            try
            {
                string kriterijum = ucFakture.TxtPretraga.Text;
                fakture = new BindingList<Domain.Faktura>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.NadjiFakture, kriterijum));
                ucFakture.DgvFakture.DataSource = fakture;
                ucFakture.DgvFakture.Refresh();
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

        public void StornirajFakturu()
        {
            if (ucFakture.DgvFakture.SelectedRows.Count == 0)
            {
                return;
            }

            Domain.Faktura faktura = (Domain.Faktura)ucFakture.DgvFakture.SelectedRows[0].DataBoundItem;

            try
            {
                FrmPrikaziFakturu frmPrikazi = new FrmPrikaziFakturu(faktura);
                frmPrikazi.ShowDialog();
                if (frmPrikazi.DialogResult == DialogResult.OK)
                {
                    frmPrikazi.Dispose();
                }
                fakture = new BindingList<Domain.Faktura>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.UcitajListuFaktura));
                ucFakture.DgvFakture.DataSource = fakture;
                ucFakture.DgvFakture.Refresh();
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
