using KorisnickiInterfejs.GUIController.FakturaController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Faktura
{
    public partial class FrmPrikaziFakturu : Form
    {
        private PrikaziFakturuController controller;
        public FrmPrikaziFakturu(Domain.Faktura faktura)
        {
            InitializeComponent();
            controller = new PrikaziFakturuController(this, faktura);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.OK();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.StornirajFakturu();
        }
    }
}
