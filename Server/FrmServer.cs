using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                Thread serverNit = new Thread(s.Listen);
                serverNit.IsBackground = true;
                serverNit.Start();
            } catch(IOException ioe)
            {
                MessageBox.Show("Server ne moze da se pokrene!" + ioe.Message);
                // ne moze da se bind-uje sa ip adresom i portom
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
