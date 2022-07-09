using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Kurs
{
    public partial class UCSviKursevi : UserControl
    {
        SviKurseviController controller;
        public UCSviKursevi()
        {
            InitializeComponent();
            controller = new SviKurseviController(this);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziKurs();
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            controller.NadjiKurseve();
        }

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = "";
        }
    }
}
