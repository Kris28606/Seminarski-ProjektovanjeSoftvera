using KorisnickiInterfejs.GUIController.Predavac;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Predavac
{
    public partial class UCPredavac : UserControl
    {
        PredavacController controller;
        public UCPredavac()
        {
            InitializeComponent();
            controller = new PredavacController(this);
            controller.Init();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeRec(txtFirstName, true);
        }

        private void btnAddCours_Click(object sender, EventArgs e)
        {
            controller.DodajPredavaca();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeRec(txtLastName, false);
        }

        private void btnDodajKurs_Click(object sender, EventArgs e)
        {
            controller.DodajKurs();
        }
    }
}
