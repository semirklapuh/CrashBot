using CrashBot.Model;
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
    public partial class frmLogin : Form
    {

        private APIService _api = new APIService("Korisnik");

        public int? _id = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                MessageBox.Show("Unesite trazena polja");
            }
            else
            {
                try
                {
                    APIService.username = txtUsername.Text;
                    APIService.pass = txtPassword.Text;



                    var result = await _api.Get<List<Model.Korisnik>>(null);

                    foreach (var item in result)
                    {
                        if (item.KorisnickoIme == txtUsername.Text && item.Lozinka == txtPassword.Text)
                        {
                            Global.prijavljeniKorisnik = new Korisnik
                            {
                                Ime = item.Ime,
                                Prezime = item.Prezime,
                                Mail = item.Mail,
                                KorisnickoIme = item.KorisnickoIme,
                                Lozinka = item.Lozinka,
                                Adresa = item.Adresa,
                                Telefon = item.Telefon,
                                KorisnikId = item.KorisnikId,
                            };
                            _id = 1;
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                    }
                    if (_id == null)
                        MessageBox.Show("Neispravan unos korisničkog imena ili lozinke!", "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form childForm = new frmSignin();

            childForm.Show();
        }


        private bool Validacija()
        {
            if (txtUsername.Text == "") 
            {
                errorProvider1.SetError(txtUsername, "Korisnicko ime je obavezno polje");             
                return true;
            }
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Lozinka je obavezno polje");
                return true;
            }
            return false;
        }
    }
}
