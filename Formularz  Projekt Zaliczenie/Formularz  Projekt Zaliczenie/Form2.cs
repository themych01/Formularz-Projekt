using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = { "Imię :"+Box1.Text, "Nazwisko :"+ Box2.Text,"Wiek :"+ Box3.Text,"Numer Telefonu :"+ Box4.Text,
                "Adres E-mail" +Box5.Text,"Zawód"+ Box6.Text,"Charakter pracy :"+Box7.Text,"Masa Ciała :"+ Box8.Text,"Wzrost :"+ Box9.Text,"Obwód Bioder :"+ Box10.Text,"Obwód Talii :"+ Box11.Text,"Choroby Alergiczne :"+Box12.Text };
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName + ".txt";
            File.WriteAllLines(filename, lines);
        }

        private void zapiszIWyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = { "Imię :"+Box1.Text, "Nazwisko :"+ Box2.Text,"Wiek :"+ Box3.Text,"Numer Telefonu :"+ Box4.Text,
                "Adres E-mail" +Box5.Text,"Zawód"+ Box6.Text,"Charakter pracy :"+Box7.Text,"Masa Ciała :"+ Box8.Text,"Wzrost :"+ Box9.Text,"Obwód Bioder :"+ Box10.Text,"Obwód Talii :"+ Box11.Text,"Choroby Alergiczne :"+Box12.Text };
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName + ".txt";
            File.WriteAllLines(filename, lines);
            this.Hide();
            Form1 d2 = new Form1();
            d2.Show();
        }

        private void wybierzPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();


        }

        private void wyczyśćToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Box1.Clear();
            Box2.Clear();
            Box3.Clear();
            Box4.Clear();
            Box5.Clear();
            Box6.Clear();
            Box7.ResetText();
            Box8.Clear();
            Box9.Clear();
            Box10.Clear();
            Box11.Clear();
            Box12.ResetText();
        }
    }
}
