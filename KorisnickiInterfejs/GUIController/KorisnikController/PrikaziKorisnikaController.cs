using Common;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.Korisnik;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController.Korisnik
{
    public class PrikaziKorisnikaController
    {
        private FrmPrikaziKorisnika korisnik;
        private Domain.Korisnik trenutni;
        public PrikaziKorisnikaController(FrmPrikaziKorisnika korisnik, Domain.Korisnik trenutni)
        {
            this.korisnik = korisnik;
            this.trenutni = trenutni;
            Init();
        }

        private void Init()
        {
            korisnik.TxtFirsName.Text = trenutni.Ime;
            korisnik.TxtLastName.Text = trenutni.Prezime;
            korisnik.TxtAdrress.Text = trenutni.Adresa;
            korisnik.TxtContact.Text = trenutni.Kontakt;
            korisnik.TxtMesto.Text = trenutni.Mesto.Naziv;
        }

        public void ObrisiKorisnika()
        {
            try
            {
                Communication.Instance.PosaljiZahtevBezRezultata(Operacija.ObrisiKorisnika, trenutni);
                MessageBox.Show("Uspesno obrisan korisnik!");
                korisnik.DialogResult = DialogResult.OK;
            } catch(ServerCommunicationException)
            {
                throw;
            } catch(SystemOperationException se)
            {
                MessageBox.Show("Korisnik ne moze da se obrise! "+se.Message);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    
        public void OK()
        {
            korisnik.DialogResult = DialogResult.OK;
        }
    
    }
}
