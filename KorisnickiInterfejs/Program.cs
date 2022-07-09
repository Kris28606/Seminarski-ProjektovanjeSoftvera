using KorisnickiInterfejs.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool cancel = false;
            while (!cancel)
            {
                try
                {
                    FrmLogIn logIn = new FrmLogIn();
                    logIn.ShowDialog();

                    if (logIn.DialogResult == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                        logIn.Dispose();
                    } else
                    {
                        cancel = true;
                    }
                }
                catch (ServerCommunicationException)
                {
                    MessageBox.Show("Server je prestao sa radom!");
                } 
            }

            
        }
    }
}
