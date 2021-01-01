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
    public partial class frmPretragaError : Form
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
        private readonly APIService _errorLog = new APIService("ErrorLog");
        public frmPretragaError()
        {
            InitializeComponent();
        }

        private async void frmPretragaError_Load(object sender, EventArgs e)
        {
            await LoadKorisnik();
        }

        private async Task LoadKorisnik()
        {
            var korisnik = await _korisnik.Get<List<Model.Korisnik>>(null);


            korisnik.Insert(0, new Model.Korisnik
            {
                KorisnikId = 0,
                KorisnickoIme = "KorisnickoIme"
            });
            cmbKorisnik.DataSource = korisnik;
            cmbKorisnik.DisplayMember = "KorisnickoIme";
            cmbKorisnik.ValueMember = "KorisnikId";

        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {

            List<Model.ErrorLog> _errorLogs = new List<Model.ErrorLog>();

            int _korisnikId = 0;

            if (cmbKorisnik.SelectedValue != null)
            {
                _korisnikId = (int)cmbKorisnik.SelectedValue;
            }

            DateTime Od = dtpOd.Value;
            DateTime Do = dtpDo.Value;

            ErrorLogSearchRequest model = new ErrorLogSearchRequest()
            {
                KorisnikId = _korisnikId,
                datumOd = Od,
                datumDo = Do
            };

            var result = await _errorLog.Get<List<Model.ErrorLog>>(model);





            foreach (var item in result)
            {

                _errorLogs.Add(new ErrorLog
                {
                    KorisnikId = item.KorisnikId,
                    Datum = item.Datum,
                    ErrorPoruka = item.ErrorPoruka,
                    ErrorLogId = item.ErrorLogId

                });
            }

            dgvErrorLista.DataSource = _errorLogs;
        }
    }
}
