using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Kurs
{
    public partial class FrmPrikaziKurs : Form
    {
        private PrikaziKursController controller;

        public FrmPrikaziKurs(Domain.Kurs selektovaniKurs)
        {
            InitializeComponent();
            controller = new PrikaziKursController(this, selektovaniKurs);
            controller.Init();
        }

        private void btnIzmeniKurs_Click(object sender, EventArgs e)
        {
            controller.IzmeniKurs();
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
