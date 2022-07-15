using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
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
            } catch(IOException)
            {
                MessageBox.Show("Server ne moze da se pokrene!");
            } catch(SocketException)
            {
                MessageBox.Show("Server je vec pokrenut!");
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            MessageBox.Show("Server je zaustavljen!");
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
