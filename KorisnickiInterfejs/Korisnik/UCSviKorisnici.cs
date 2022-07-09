using KorisnickiInterfejs.GUIController.Korisnik;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Korisnik
{
    public partial class UCSviKorisnici : UserControl
    {
        
        private SviKorisniciController controller;
        public UCSviKorisnici()
        {
            InitializeComponent();
            controller = new SviKorisniciController(this);
        }

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = "";
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            controller.NadjiKorisnike();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziKorisnika();
        }
    }
}
