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
                InicijalizujDgvKursevi(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva));

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

        public void NadjiKurseve()
        {
            try
            {
                string kriterijum = kursevi.TxtPretraga.Text;
                if(string.IsNullOrEmpty(kriterijum))
                {
                    InicijalizujDgvKursevi(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva));
                    return;
                }
                InicijalizujDgvKursevi(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.NadjiKurseve, kriterijum));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
                InicijalizujDgvKursevi(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void InicijalizujDgvKursevi(List<Domain.Kurs> lista)
        {
            listaKurseva = new BindingList<Domain.Kurs>(lista);
            kursevi.DgvKursevi.DataSource = listaKurseva;
            kursevi.DgvKursevi.Columns["KursId"].Visible = false;
            kursevi.DgvKursevi.Columns["NazivTabele"].Visible = false;
            kursevi.DgvKursevi.Columns["Vrednosti"].Visible = false;
            kursevi.DgvKursevi.Columns["Uslov"].Visible = false;
            kursevi.DgvKursevi.Columns["Output"].Visible = false;
            kursevi.DgvKursevi.Columns["Kriterijum"].Visible = false;
            kursevi.DgvKursevi.Columns["JoinUslov"].Visible = false;
            kursevi.DgvKursevi.Columns["UpdateUslov"].Visible = false;
            kursevi.DgvKursevi.Refresh();
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

                selektovani = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.Kurs>(Operacija.UcitajKurs, selektovani);

                PrikaziFormu(selektovani);
                InicijalizujDgvKursevi(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
                InicijalizujDgvKursevi(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Kurs>>(Operacija.UcitajListuKurseva));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void PrikaziFormu(Domain.Kurs selektovani)
        {
            FrmPrikaziKurs frmPrikazi = new FrmPrikaziKurs(selektovani);
            frmPrikazi.ShowDialog();

            if (frmPrikazi.DialogResult == DialogResult.OK)
            {
                frmPrikazi.Dispose();
            }
        }
    }
}

