using ApplicationLogic;
using KorisnickiInterfejs.Faktura;
using KorisnickiInterfejs.Korisnik;
using KorisnickiInterfejs.Kurs;
using KorisnickiInterfejs.Predavac;
using KorisnickiInterfejs.ServerCommunication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            pnlMain.Visible = false;
            lblImePrijavljenog.Text = Session.Session.Instance.TrenutnoPrijavljeni.Ime;
            lblPrezimePrijavljenog.Text = Session.Session.Instance.TrenutnoPrijavljeni.Prezime;

        }

        private void ChangePanel(UserControl uc)
        {
            pnlMain.Visible = true;
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Visible = false;
        }

        private void novaFakturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCFaktura());
        }

        private void dodajNoviKursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKurs());
        }

        private void kurseviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCSviKursevi());
        }

        private void dodajNovogKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCKorisnik());
        }

        private void dodajNovogPredavacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCPredavac());
        }

        private void predavaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCSviPredavaci());
        }

        private void stornirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCSveFakture());
        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCSviKorisnici());
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Communication.Instance.ZatvoriKonekciju();
        }
    }
}
