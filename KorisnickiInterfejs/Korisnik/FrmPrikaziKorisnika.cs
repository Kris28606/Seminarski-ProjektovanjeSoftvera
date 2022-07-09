using KorisnickiInterfejs.GUIController.Korisnik;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Korisnik
{
    public partial class FrmPrikaziKorisnika : Form
    {
        private PrikaziKorisnikaController controller;
        public FrmPrikaziKorisnika(Domain.Korisnik korisnik)
        {
            InitializeComponent();
            controller = new PrikaziKorisnikaController(this, korisnik);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.OK();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            controller.ObrisiKorisnika();
        }
    }
}
