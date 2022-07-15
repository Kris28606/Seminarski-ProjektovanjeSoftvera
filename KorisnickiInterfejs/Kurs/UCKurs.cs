using System;
using System.Windows.Forms;
using KorisnickiInterfejs.GUIController;

namespace KorisnickiInterfejs.Kurs
{
    public partial class UCKurs : UserControl
    {
        private KursController controller;
        public UCKurs()
        {
            InitializeComponent();
            controller = new KursController(this);
        }

        private void btnAddCours_Click(object sender, EventArgs e)
        {
            controller.DodajKurs();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeDouble();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            controller.DaLiJeInt();
        }

    }
}
