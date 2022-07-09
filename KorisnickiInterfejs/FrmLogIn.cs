using KorisnickiInterfejs.GUIController;
using System;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmLogIn : Form
    {
        private UserController controller;

        public FrmLogIn()
        {
            InitializeComponent();
            controller = new UserController(this);
            txtEmail.Text = "stanisavljevickristina28@gmail.com";
            txtPassword.Text = "kris";
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            controller.ChangeShowIcon(false);
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            controller.ChangeShowIcon(true);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            controller.LogIn();
        }
    }
}
