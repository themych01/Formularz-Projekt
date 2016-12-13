using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz__Projekt_Zaliczenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 d1 = new Form2();
            d1.Show();
            this.Hide();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 d1 = new Form2();
            d1.Show();
            this.Hide();

        }
    }
}
