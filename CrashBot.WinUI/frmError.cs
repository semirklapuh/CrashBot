using CrashBot.Model;
using CrashBot.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashBot.WinUI
{
    public partial class frmError : Form
    {
        private readonly APIService _errorLog = new APIService("ErrorLog");
        public frmError()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmError_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = Global.prijavljeniKorisnik.KorisnickoIme;
        }

        private async void btnPosalji_Click(object sender, EventArgs e)
        {

            if (Validacija())
            {
                MessageBox.Show("Morate unijeti tekst poruke.", "Info", MessageBoxButtons.OK);
            }
            else
            {
                SmtpClient client = new SmtpClient("smtp.office365.com", 587);


                NetworkCredential cred = new NetworkCredential("semir.klapuh@edu.fit.ba", "Programiranje2016");

                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();

                // Sender e-mail address.
                Msg.From = new MailAddress("semir.klapuh@edu.fit.ba");//Nothing But Above Credentials or your credentials (*******@gmail.com)

                // Recipient e-mail address.
                Msg.To.Add("semir.klapuh@edu.fit.ba");

                // Assign the subject of our message.
                Msg.Subject = txtNaslov.Text + " - " + Global.prijavljeniKorisnik.KorisnickoIme;

                // Create the content(body) of our message.
                Msg.Body = txtMail.Text;

                // Send our account login details to the client.
                client.Credentials = cred;

                //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;

                //Confirmation After Click the Button
                //label5.Text = "Mail Sended Succesfully";

                // Send our email.
                client.Send(Msg);


                ErrorLogUpsertRequest model = new ErrorLogUpsertRequest();

                model.ErrorPoruka = txtMail.Text;
                model.KorisnikId = Global.prijavljeniKorisnik.KorisnikId;
                model.Datum = DateTime.Now;


                var nesto = await _errorLog.Insert<Model.ErrorLog>(model);

                MessageBox.Show("Uspjesno ste prijavili gresku.", "Info", MessageBoxButtons.OK);
                this.Close();
            }

            
        }

        private bool Validacija()
        {
            
            if (txtMail.Text == "")
            {
                errorProvider1.SetError(txtMail, "Morate unijeti tekst poruke.");
                return true;
            }
            

            return false;
        }

        private void btnPretraziGreske_Click(object sender, EventArgs e)
        {
            Form childForm = new frmPretragaError();

            childForm.Show();
        }
    }
}
