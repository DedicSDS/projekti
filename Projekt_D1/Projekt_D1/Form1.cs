using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_D1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Ali zares želite zapreti program?", "Izhod", MessageBoxButtons.YesNo);
            if (rezultat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void vstop_Click(object sender, EventArgs e)
        {
            Form2 okno2 = new Form2();
            okno2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
