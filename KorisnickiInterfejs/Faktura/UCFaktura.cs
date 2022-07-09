using KorisnickiInterfejs.GUIController.FakturaController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs.Faktura
{
    public partial class UCFaktura : UserControl
    {
        private FakturaController controller;
        public UCFaktura()
        {
            InitializeComponent();
            controller = new FakturaController(this);
            controller.Init();
        }

        private void cbKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.PromeniCenuStavke();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            controller.DodajStavku();
        }

        private void btnSacuvajFakturu_Click(object sender, EventArgs e)
        {
            controller.SacuvajFakturu();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            controller.ObrisiStavku();
        }

        private void cbKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.PromeniKurseveZaKorisnika();
        }
    }
}
