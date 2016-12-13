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
            string[] lines = File.ReadAllLines(openFileDialog1.FileName);
            Box1.Text = lines[0].Remove(0,6);
            Box2.Text = lines[1];
            Box3.Text = lines[2];
            Box4.Text = lines[3];
            Box5.Text = lines[4];
            Box6.Text = lines[5];
            Box7.Text = lines[6];
            Box8.Text = lines[7];
            Box9.Text = lines[8];
            Box10.Text = lines[9];
            Box11.Text = lines[10];
            Box12.Text = lines[11];

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
