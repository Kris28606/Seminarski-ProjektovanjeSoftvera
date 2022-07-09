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
                List<Domain.Predavac> lista = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca);
                listaPredavaca = new BindingList<Domain.Predavac>(lista);
                predavaci.DgvPredavaci.DataSource = listaPredavaca;
                predavaci.DgvPredavaci.Columns["PredavacId"].Visible = false;
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
    
        public void NadjiPredavace()
        {
            if (string.IsNullOrEmpty(predavaci.TxtPretraga.Text))
            {
                return;
            }
            try
            {
                string kriterijum = predavaci.TxtPretraga.Text;
                List<Domain.Predavac> lista = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.NadjiPredavace, kriterijum);
                listaPredavaca = new BindingList<Domain.Predavac>(lista);
                predavaci.DgvPredavaci.DataSource = listaPredavaca;
                predavaci.DgvPredavaci.Refresh();
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
    
        public void PrikaziPredavaca()
        {
            if (predavaci.DgvPredavaci.SelectedRows.Count == 0)
            {
                return;
            }

            Domain.Predavac selektovani = (Domain.Predavac)predavaci.DgvPredavaci.SelectedRows[0].DataBoundItem;

            FrmPrikaziPredavaca frmPrikazi = new FrmPrikaziPredavaca(selektovani);
            frmPrikazi.ShowDialog();
            if (frmPrikazi.DialogResult == DialogResult.OK)
            {
                frmPrikazi.Dispose();
            }
            try
            {
                List<Domain.Predavac> lista = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Predavac>>(Common.Operacija.UcitajListuPredavaca);
                listaPredavaca = new BindingList<Domain.Predavac>(lista);
                predavaci.DgvPredavaci.DataSource = listaPredavaca;
                predavaci.DgvPredavaci.Refresh();
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



    }
}
