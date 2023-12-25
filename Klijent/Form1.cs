using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class Form1 : Form
    {
        private List<int> brojevi = new List<int>();
        int pokusaj = 5;
        public Form1()
        {
            InitializeComponent();
            if (Komunikacija.Instance.Connect())
            {
                MessageBox.Show("uspesno ste se povezali sa serverom");
            }
            else
            {
                MessageBox.Show("Neuspesno");
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Pokusaj((Button)sender);
        }
       
        public void Pokusaj(Button button)
        {
            
            Poruka p = new Poruka();
            if (pokusaj == 0)
            {
                MessageBox.Show("Nema vise bajo!");
                this.Close();              
                return;
            }
            p.Pozicija = int.Parse(button.Name.Substring(6,1));
            p.Operacija = Operacija.Pokusaj;
            Komunikacija.Instance.Pokusaj(p);
            p = Komunikacija.Instance.PrimiOdg();
            if (p.Pogodak)
            {
                button.Text = p.Broj.ToString();
                brojevi.Add(p.Broj);
                
                if (brojevi.Count == 3)
                {
                    brojevi.Sort();
                    MessageBox.Show($"Bravo kralju! Broj je {brojevi[0] + brojevi[1] * 10 + brojevi[2]*100}");
                    this.Close();
                }

            }
            else
            {
                button.Text = "-1";
                
               
            }
            pokusaj--;


        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Poruka p = new Poruka();
            p.Operacija = Operacija.Kraj;
            Komunikacija.Instance.Pokusaj(p);
            Komunikacija.Instance.Stop();
        }
    }
}
