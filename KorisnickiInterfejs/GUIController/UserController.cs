using Domain;
using KorisnickiInterfejs.Exceptions;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KorisnickiInterfejs.GUIController
{
    public class UserController
    {
        private FrmLogIn logIn;
        public UserController(FrmLogIn login)
        {
            logIn = login;
        }

        public void LogIn()
        {
            TextBox txtEmail = logIn.TxtEmail;
            TextBox txtPassword = logIn.TxtPassword;

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                txtEmail.BackColor = Color.LightGoldenrodYellow;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = Color.LightGoldenrodYellow;
            }

            User user = new User
            {
                Email = txtEmail.Text,
                Sifra = txtPassword.Text
            };
            try
            {
                Communication.Instance.Connect();
                user = Communication.Instance.PosaljiZahtevVratiRezultat<User>(Common.Operacija.Prijava, user);
                Session.Session.Instance.TrenutnoPrijavljeni = user;
                MessageBox.Show("Dobrodosli, " + user.Ime + " " + user.Prezime + "!");
                logIn.DialogResult = DialogResult.OK;

            }
            catch (SystemOperationException es)
            {
                MessageBox.Show(es.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangeShowIcon(bool show)
        {
            if (show)
            {
                logIn.PbShow.Visible = true;
                logIn.PbHide.Visible = false;
                logIn.TxtPassword.PasswordChar = '*';
            } else
            {
                logIn.PbShow.Visible = false;
                logIn.PbHide.Visible = true;
                logIn.TxtPassword.PasswordChar = '\0';
            }
        }
    }
}
