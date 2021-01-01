using CrashBot.Model;
using CrashBot.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashBot.WinUI
{
    public partial class frmProfil : Form
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
        public frmProfil()
        {
            InitializeComponent();
        }

        private async void frmProfil_Load(object sender, EventArgs e)
        {
            var korisnik = await _korisnik.GetById<Model.Korisnik>(Global.prijavljeniKorisnik.KorisnikId);

            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtAdresa.Text = korisnik.Adresa;
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
            txtMail.Text = korisnik.Mail;
            txtTelefon.Text = korisnik.Telefon;
            txtLozinka.Text = korisnik.Lozinka;
            

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (Validacija())
            {
                MessageBox.Show("Ispravno unesite podatke.", "Info", MessageBoxButtons.OK);
            }
            else
            {

                if (txtNovaLozinka.Text != "")
                {
                    txtLozinka.Text = txtNovaLozinka.Text;
                }
                KorisnikUpsertRequest model = new KorisnikUpsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Mail = txtMail.Text,
                    Telefon = txtTelefon.Text,
                    Lozinka = txtLozinka.Text,                   
                };

                var nesto = await _korisnik.Update<Model.Korisnik>(Global.prijavljeniKorisnik.KorisnikId, model);
                MessageBox.Show("Uspješno promijenjeni podaci!", "Info", MessageBoxButtons.OK);
            }
            

            
        }

        private bool Validacija()
        {
            if (txtIme.Text == "" || txtPrezime.Text == "")
            {
                errorProvider1.SetError(txtIme, "Ime je obavezno polje");
                errorProvider1.SetError(txtPrezime, "Prezime je obavezno polje");

                return true;
            }
            if (txtKorisnickoIme.Text == "")
            {
                errorProvider1.SetError(txtKorisnickoIme, "Korisnicko ime je obavezno polje");
                return true;
            }
            if (txtNovaLozinka.Text != txtPonovljenaLozinka.Text)
            {
                errorProvider1.SetError(txtNovaLozinka, "Neispravno unesena lozinka");
                errorProvider1.SetError(txtPonovljenaLozinka, "Neispravno unesena lozinka");
                return true;
            }

            return false;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
