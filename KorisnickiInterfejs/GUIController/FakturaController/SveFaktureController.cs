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
        }

        public void Init()
        {
            try
            {
                InicijalizujDgvFakture(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.UcitajListuFaktura));
            } catch(ServerCommunicationException)
            {
                throw;
            } catch(SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void InicijalizujDgvFakture(List<Domain.Faktura> lista)
        {
            fakture = new BindingList<Domain.Faktura>(lista);
            ucFakture.DgvFakture.DataSource = fakture;
            ucFakture.DgvFakture.Columns["FakturaId"].Visible = false;
            ucFakture.DgvFakture.Columns["NazivTabele"].Visible = false;
            ucFakture.DgvFakture.Columns["Vrednosti"].Visible = false;
            ucFakture.DgvFakture.Columns["Uslov"].Visible = false;
            ucFakture.DgvFakture.Columns["Output"].Visible = false;
            ucFakture.DgvFakture.Columns["Kriterijum"].Visible = false;
            ucFakture.DgvFakture.Columns["JoinUslov"].Visible = false;
            ucFakture.DgvFakture.Columns["UpdateUslov"].Visible = false;
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
                fakture = new BindingList<Domain.Faktura>();
                InicijalizujDgvFakture(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.NadjiFakture, kriterijum));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                InicijalizujDgvFakture(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.UcitajListuFaktura));
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
                faktura = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.Faktura>(Operacija.UcitajFakturu, faktura);

                PokreniFormu(faktura);

                InicijalizujDgvFakture(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.UcitajListuFaktura));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                InicijalizujDgvFakture(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Faktura>>(Operacija.UcitajListuFaktura));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void PokreniFormu(Domain.Faktura faktura)
        {
            FrmPrikaziFakturu frmPrikazi = new FrmPrikaziFakturu(faktura);
            frmPrikazi.ShowDialog();
            if (frmPrikazi.DialogResult == DialogResult.OK)
            {
                frmPrikazi.Dispose();
            }
        }
    }
}
