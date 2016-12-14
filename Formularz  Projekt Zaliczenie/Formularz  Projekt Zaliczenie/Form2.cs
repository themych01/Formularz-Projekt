﻿using System;
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
            string[] lines = {"Imię :"+Box1.Text, "Nazwisko :"+ Box2.Text,"Wiek :"+ Box3.Text,"Numer Telefonu :"+ Box4.Text,
                "Adres E-mail :" +Box5.Text,"Zawód :" + Box6.Text,"Tryb życia :"+Box7.Text,"Masa Ciała :"+ Box8.Text,
                "Wzrost :" + Box9.Text,"Obwód Bioder :"+ Box10.Text,"Obwód Talii :"+ Box11.Text,
                "Choroby Alergiczne :" +Box12.Text , "BMI :" + button1.Text,"Płeć :"+Płeć.Text};
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName + ".txt";
            File.WriteAllLines(filename, lines);
        }

        private void zapiszIWyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = {"Imię :"+Box1.Text, "Nazwisko :"+ Box2.Text,"Wiek :"+ Box3.Text,"Numer Telefonu :"+ Box4.Text,
                "Adres E-mail :" + Box5.Text,"Zawód :"+ Box6.Text,"Tryb życia :"+Box7.Text,
                "Masa Ciała :" + Box8.Text,"Wzrost :"+ Box9.Text,"Obwód Bioder :" + Box10.Text,"Obwód Talii :"+ Box11.Text,
                "Choroby Alergiczne :" +Box12.Text, "BMI :" + button1.Text,"Płeć :"+Płeć.Text };
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
            Box2.Text = lines[1].Remove(0,10);
            Box3.Text = lines[2].Remove(0,6);
            Box4.Text = lines[3].Remove(0,16);
            Box5.Text = lines[4].Remove(0,14);
            Box6.Text = lines[5].Remove(0,7);
            Box7.Text = lines[6].Remove(0,12);
            Box8.Text = lines[7].Remove(0,12);
            Box9.Text = lines[8].Remove(0,8);
            Box10.Text = lines[9].Remove(0,14);
            Box11.Text = lines[10].Remove(0,13);
            Box12.Text = lines[11].Remove(0,20);
            button1.Text = lines[12].Remove(0, 5);
            Płeć.Text = lines[13].Remove(0, 6);
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
            button1.ResetText();
            Płeć.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double BMI;
            BMI = Convert.ToDouble(Box8.Text) / ((Convert.ToDouble(Box9.Text))*(Convert.ToDouble(Box9.Text))/10000);
            button1.Text = Convert.ToString(BMI);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A;
            A = 66.5 + (13.7 * Convert.ToDouble(Box8.Text) + (5 * Convert.ToDouble(Box9.Text)) - (6.8 * Convert.ToDouble(Box3.Text)));
            double B;
            B = Convert.ToDouble(Box7.Text.Remove(2, 2);
            double C;
            C = A * B;
            button2.Text = Convert.ToString(C);






        }
    }
}
