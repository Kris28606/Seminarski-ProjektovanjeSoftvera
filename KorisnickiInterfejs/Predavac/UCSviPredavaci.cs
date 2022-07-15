using KorisnickiInterfejs.GUIController.Predavac;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Predavac
{
    public partial class UCSviPredavaci : UserControl
    {
        private SviPredavaciController controller;
        public UCSviPredavaci()
        {
            InitializeComponent();
            controller = new SviPredavaciController(this);
            controller.Init();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            controller.PrikaziPredavaca();
        }

        private void txtPretraga_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = "";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            controller.NadjiPredavace();
        }
    }
}
