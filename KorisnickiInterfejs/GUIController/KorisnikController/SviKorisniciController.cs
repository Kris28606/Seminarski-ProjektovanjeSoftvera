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
                InicijalizujDgvKorisnici(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
            }
            catch (ServerCommunicationException)
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

        private void InicijalizujDgvKorisnici(List<Domain.Korisnik> lista) {
            listaKorisnika = new BindingList<Domain.Korisnik>(lista);
            korisnici.DgvKorisnici.DataSource = listaKorisnika;
            korisnici.DgvKorisnici.Columns["KorisnikId"].Visible = false;
            korisnici.DgvKorisnici.Columns["NazivTabele"].Visible = false;
            korisnici.DgvKorisnici.Columns["Vrednosti"].Visible = false;
            korisnici.DgvKorisnici.Columns["Uslov"].Visible = false;
            korisnici.DgvKorisnici.Columns["Output"].Visible = false;
            korisnici.DgvKorisnici.Columns["Kriterijum"].Visible = false;
            korisnici.DgvKorisnici.Columns["JoinUslov"].Visible = false;
            korisnici.DgvKorisnici.Columns["UpdateUslov"].Visible = false;
            korisnici.DgvKorisnici.Refresh();
        }

        public void NadjiKorisnike()
        {   try
            {
                string kriterijum = korisnici.TxtPretraga.Text;
                if (string.IsNullOrEmpty(kriterijum))
                {
                    InicijalizujDgvKorisnici(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
                    return;
                }
                InicijalizujDgvKorisnici(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.NadjiKorisnike, kriterijum));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                InicijalizujDgvKorisnici(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
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

                selektovani = Communication.Instance.PosaljiZahtevVratiRezultat<Domain.Korisnik>(Operacija.UcitajKorisnika, selektovani);
                
                PokreniFormu(selektovani);

                InicijalizujDgvKorisnici(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
            }
            catch (ServerCommunicationException)
            {
                throw;
            }
            catch (SystemOperationException se)
            {
                MessageBox.Show(se.Message);
                InicijalizujDgvKorisnici(Communication.Instance.PosaljiZahtevVratiRezultat<List<Domain.Korisnik>>(Operacija.UcitajListuKorisnika));
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void PokreniFormu(Domain.Korisnik selektovani)
        {
            FrmPrikaziKorisnika frmPrikazi = new FrmPrikaziKorisnika(selektovani);
            frmPrikazi.ShowDialog();
            if (frmPrikazi.DialogResult == DialogResult.OK)
            {
                frmPrikazi.Dispose();
            }
        }
    }
}
