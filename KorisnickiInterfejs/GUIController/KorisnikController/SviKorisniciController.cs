using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Korisnik;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController.Korisnik
{
    public class SviKorisniciController
    {
        private UCSviKorisnici korisnici;
        private BindingList<Domain.Korisnik> listaKorisnika;

        public SviKorisniciController(UCSviKorisnici korisnici)
        {
            this.korisnici = korisnici;
            Init();
        }

        private void Init()
        {
            try
            {
                listaKorisnika = new BindingList<Domain.Korisnik>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
                korisnici.DgvKorisnici.DataSource = listaKorisnika;
                korisnici.DgvKorisnici.Columns["KorisnikId"].Visible = false;
            }
            catch(ServerCommunicationException)
            {
                throw;
            }catch(SystemOperationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        public void NadjiKorisnike()
        {
            string kriterijum = korisnici.TxtPretraga.Text;
            if (string.IsNullOrEmpty(kriterijum))
            {
                return;
            }
            try
            {
                listaKorisnika = new BindingList<Domain.Korisnik>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.NadjiKorisnike, kriterijum));
                korisnici.DgvKorisnici.DataSource = listaKorisnika;
                korisnici.DgvKorisnici.Refresh();
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

        public void PrikaziKorisnika()
        {
            if (korisnici.DgvKorisnici.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                Domain.Korisnik selektovani = (Domain.Korisnik)korisnici.DgvKorisnici.SelectedRows[0].DataBoundItem;
                FrmPrikaziKorisnika frmPrikazi = new FrmPrikaziKorisnika(selektovani);
                frmPrikazi.ShowDialog();
                if (frmPrikazi.DialogResult == DialogResult.OK)
                {
                    frmPrikazi.Dispose();
                }
                listaKorisnika = new BindingList<Domain.Korisnik>(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
                korisnici.DgvKorisnici.DataSource = listaKorisnika;
                korisnici.DgvKorisnici.Refresh();
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
