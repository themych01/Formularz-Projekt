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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 d2 = new Form1();
            d2.Show();
        }
    }
}
