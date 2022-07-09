using KorisnickiInterfejs.GUIController.FakturaController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Faktura
{
    public partial class UCSveFakture : UserControl
    {
        private SveFaktureController controller;
        public UCSveFakture()
        {
            InitializeComponent();
            controller = new SveFaktureController(this);
        }

        private void btnNadji_Click(object sender, EventArgs e)
        {
            controller.NadjiFakturu();
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            controller.StornirajFakturu();
        }

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = "";
        }
    }
}
