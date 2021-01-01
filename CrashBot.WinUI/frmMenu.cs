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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnJoystick_Click(object sender, EventArgs e)
        {
            Form childForm = new Form1();
           
            childForm.Show();
            

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Application.Restart();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Form childForm = new frmProfil();

            childForm.Show();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Form childForm = new frmError();

            childForm.Show();
        }
    }
}
