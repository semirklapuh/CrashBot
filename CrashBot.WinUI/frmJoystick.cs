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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //serialPort1.Open();
        }

       

        private void btnGoAuto_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form childForm = new frmMenu();
            this.Close();
            //childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
        }

        private void pctUp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("U");
        }

        private void pctDown_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }

        private void pctLeft_Click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
        }

        private void pctRight_Click(object sender, EventArgs e)
        {
            serialPort1.Write("R");
        }
    }
}
