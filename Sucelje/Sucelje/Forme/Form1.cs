using System;
using Sucelje.Forme;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucelje
{
    public partial class Biblioteka : Form
    {
        public Biblioteka()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void korisniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void korisniciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Korisnici korisnik = new Korisnici();
            korisnik.Show();
        }

        private void knjigeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Knjige knjige = new Knjige();  
            knjige.Show();
        }
    }

    class Korisnik
    {
        int korisnikID;
        string ime;
        string mail;
        string adresa;
        int broj;

        public int KorisnikID { get => korisnikID; set => korisnikID = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Ime { get => ime; set => mail = value; }
        public int Broj { get => broj; set => broj = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public Korisnik(int korisnikID, string ime, string mail, string adresa, int broj)
        {
            this.korisnikID = korisnikID;
            this.ime = ime;
            this.mail = mail;
            this.adresa = adresa;
            this.broj = broj;
        }

    }
}
