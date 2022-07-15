using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Predavac;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController.Predavac
{
    public class SviPredavaciController
    {
        private UCSviPredavaci predavaci;
        private BindingList<Domain.Predavac> listaPredavaca;

        public SviPredavaciController(UCSviPredavaci predavaci)
        {
            this.predavaci = predavaci;
        }

        public void Init()
        {
            try
            {
                InicijalizujDgvPredavaci(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca));
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
    
        private void InicijalizujDgvPredavaci(List<Domain.Predavac> lista)
        {
            listaPredavaca = new BindingList<Domain.Predavac>(lista);
            predavaci.DgvPredavaci.DataSource = listaPredavaca;
            predavaci.DgvPredavaci.Columns["PredavacId"].Visible = false;
            predavaci.DgvPredavaci.Columns["NazivTabele"].Visible = false;
            predavaci.DgvPredavaci.Columns["Vrednosti"].Visible = false;
            predavaci.DgvPredavaci.Columns["Uslov"].Visible = false;
            predavaci.DgvPredavaci.Columns["Output"].Visible = false;
            predavaci.DgvPredavaci.Columns["Kriterijum"].Visible = false;
            predavaci.DgvPredavaci.Columns["JoinUslov"].Visible = false;
            predavaci.DgvPredavaci.Columns["UpdateUslov"].Visible = false;
            predavaci.DgvPredavaci.Refresh();
        }

        public void NadjiPredavace()
        {
            if (string.IsNullOrEmpty(predavaci.TxtPretraga.Text))
            {
                InicijalizujDgvPredavaci(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca));
                return;
            }
            try
            {
                string kriterijum = predavaci.TxtPretraga.Text;
                InicijalizujDgvPredavaci(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.NadjiPredavace, kriterijum));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
                InicijalizujDgvPredavaci(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    
        public void PrikaziPredavaca()
        {
            if (predavaci.DgvPredavaci.SelectedRows.Count == 0)
            {
                return;
            }

            Domain.Predavac selektovani = (Domain.Predavac)predavaci.DgvPredavaci.SelectedRows[0].DataBoundItem;
            try
            {
                selektovani = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.Predavac>(Operacija.UcitajPredavaca, selektovani);

                PrikaziFormu(selektovani);

                InicijalizujDgvPredavaci(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
                InicijalizujDgvPredavaci(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void PrikaziFormu(Domain.Predavac selektovani)
        {
            FrmPrikaziPredavaca frmPrikazi = new FrmPrikaziPredavaca(selektovani);
            frmPrikazi.ShowDialog();
            if (frmPrikazi.DialogResult == DialogResult.OK)
            {
                frmPrikazi.Dispose();
            }
        }
    }
}
