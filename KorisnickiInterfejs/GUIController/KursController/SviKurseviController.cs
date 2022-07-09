using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Kurs;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class SviKurseviController
    {
        BindingList<Domain.Kurs> listaKurseva;
        private UCSviKursevi kursevi;

        public SviKurseviController(UCSviKursevi ucKursevi)
        {
            this.kursevi = ucKursevi;
            Init();
        }

        private void Init()
        {
            try
            {
                List<Domain.Kurs> lista = Communication.Instance.PosaljiZahtevVratiRezultat < List<Domain.Kurs> >(Operacija.UcitajListuKurseva);
                listaKurseva = new BindingList<Domain.Kurs>(lista);
                kursevi.DgvKursevi.DataSource = listaKurseva;
                kursevi.DgvKursevi.Columns["KursId"].Visible = false;
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

        public void NadjiKurseve()
        {
            try
            {
                string kriterijum = kursevi.TxtPretraga.Text;
                List<Domain.Kurs> lista = Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.NadjiKurseve, kriterijum);
                listaKurseva = new BindingList<Domain.Kurs>(lista);
                kursevi.DgvKursevi.DataSource = listaKurseva;
                kursevi.DgvKursevi.Refresh();
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

        public void PrikaziKurs()
        {
            if (kursevi.DgvKursevi.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                Domain.Kurs selektovani = (Domain.Kurs)kursevi.DgvKursevi.SelectedRows[0].DataBoundItem;

                FrmPrikaziKurs frmPrikazi = new FrmPrikaziKurs(selektovani);
                frmPrikazi.ShowDialog();

                if (frmPrikazi.DialogResult == DialogResult.OK)
                {
                    frmPrikazi.Dispose();
                }
                List<Domain.Kurs> lista= Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva);
                listaKurseva = new BindingList<Domain.Kurs>(lista);
                kursevi.DgvKursevi.DataSource = listaKurseva;
                kursevi.DgvKursevi.Refresh();
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

