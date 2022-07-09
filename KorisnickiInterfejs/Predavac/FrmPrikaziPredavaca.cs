using KorisnickiInterfejs.GUIController.Predavac;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Predavac
{
    public partial class FrmPrikaziPredavaca : Form
    {
        private PrikaziPredavacaController controller;

        public FrmPrikaziPredavaca(Domain.Predavac prikazaniPredavac)
        {
            InitializeComponent();
            controller = new PrikaziPredavacaController(this, prikazaniPredavac);
            controller.Init();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeRec(txtFirstName, true);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeRec(txtLastName, false);
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            controller.IzbaciKurs();
        }

        private void btnDodajKurs_Click(object sender, EventArgs e)
        {
            controller.DodajKurs();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.IzmeniPredavaca();
        }

    }
}
