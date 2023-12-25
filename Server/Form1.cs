using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private static List<int> brojevi = new List<int>();
        private static List<int> pozicije = new List<int>();

        private Server server = new Server();
        private User admin = new User();

        bool popunjeno = false;
        public Form1()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            btnPokreniIgru.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = false;
            txtIIme.Enabled = false;
            txtPrezime.Enabled = false;
            tableLayoutPanel1.Enabled = false;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string password = txtPassword.Text;
            if (Login(username, password))
            {
                txtIIme.Text = admin.Ime;
                txtPrezime.Text = admin.Prezime;
                btnStart.Enabled = true;
                btnLogin.Enabled = false;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private bool Login(string username, string password)
        {
            foreach (User u in Server.useri)
            {
                if (username == u.Email && password == u.Password)
                {
                    admin.Ime = u.Ime;
                    admin.Prezime = u.Prezime;
                    admin.Password = u.Password;
                    admin.Email = u.Email;
                    return true;
                }
            }
            return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Pokreni();

            if (!popunjeno)
            {
                tableLayoutPanel1.Enabled = true;
            }
            else
            {
                btnPokreniIgru.Enabled = true;
            }
            btnStart.Enabled = false;
            btnStop.Enabled = true;


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            tableLayoutPanel1.Enabled = false;

            btnPokreniIgru.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;

        }



        private void broj_TextChanged(object sender, EventArgs e)
        {
            Provera((TextBox)sender);
        }
        public void Provera(TextBox txt)
        {
            if (Validacija(txt.Text))
            {

                if (!brojevi.Contains(Int32.Parse(txt.Text)))
                {
                    brojevi.Add(Int32.Parse(txt.Text));
                    txt.Enabled = false;
                    pozicije.Add(int.Parse(txt.Name.Substring(4, 1)));
                    if (brojevi.Count == 3)
                    {
                        tableLayoutPanel1.Enabled = false;
                        btnPokreniIgru.Enabled = true;                       
                        popunjeno = true;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Broj vec postoji.");
                    txt.Text = "";
                }
            }
            else if (txt.Text != "" && !char.IsDigit(txt.Text[0]))
            {
                MessageBox.Show("Nije broj");
                txt.Text = "";
            }
        }
        private bool Validacija(string broj)
        {
            return broj != "" && char.IsDigit(broj[0]);
        }
        private void btnPokreniIgru_Click(object sender, EventArgs e)
        {
            Thread nit = new Thread(server.PoveziIgraca);
            nit.IsBackground = true;
            nit.Start();
        }
        internal static Poruka Proveri(Poruka p)
        {
            if (pozicije.Contains(p.Pozicija))
            {
                p.Broj = brojevi[pozicije.IndexOf(p.Pozicija)];
                p.Pogodak = true;
            }
            else
            {
                p.Pogodak = false;
            }
            return p;

        }
    }
}
