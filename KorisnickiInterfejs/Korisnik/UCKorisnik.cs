using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class UCKorisnik : UserControl
    {
        private KorisnikController controller;
        public UCKorisnik()
        {
            InitializeComponent();
            controller = new KorisnikController(this);
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            controller.DodajKorisnika();
        }


        private void txtFirsName_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeRec(txtFirsName, true);
        }
        
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeRec(txtLastName, false);
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            controller.DaliJeBroj();
        }
        
        private void btnDodajKurs_Click(object sender, EventArgs e)
        {
            controller.DodajKurs();
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            controller.IzbaciKurs();
        }
    }
}
