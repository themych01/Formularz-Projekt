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
            string[] lines = {"Imię :"+Imie.Text, "Nazwisko :"+ Nazwisko.Text,"Wiek :"+ Wiek.Text,"Numer Telefonu :"+ NumerTelefonu.Text,
                "Adres E-mail :" +Email.Text,"Zawód :" + Zawód.Text,"Tryb życia :"+TrybŻycia.Text,"Masa Ciała :"+ MasaCiała.Text,
                "Wzrost :" + Wzrost.Text,"Obwód Bioder :"+ ObwBioder.Text,"Obwód Talii :"+ ObwTalii.Text,
                "Choroby Alergiczne :" +Box12.Text , "BMI :" + button1.Text,"Płeć :"+Płeć.Text};
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName + ".txt";
            File.WriteAllLines(filename, lines);
        }

        private void zapiszIWyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = {"Imię :"+Imie.Text, "Nazwisko :"+ Nazwisko.Text,"Wiek :"+ Wiek.Text,"Numer Telefonu :"+ NumerTelefonu.Text,
                "Adres E-mail :" + Email.Text,"Zawód :"+ Zawód.Text,"Tryb życia :"+TrybŻycia.Text,
                "Masa Ciała :" + MasaCiała.Text,"Wzrost :"+ Wzrost.Text,"Obwód Bioder :" + ObwBioder.Text,"Obwód Talii :"+ ObwTalii.Text,
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
            Imie.Text = lines[0].Remove(0,6);
            Nazwisko.Text = lines[1].Remove(0,10);
            Wiek.Text = lines[2].Remove(0,6);
            NumerTelefonu.Text = lines[3].Remove(0,16);
            Email.Text = lines[4].Remove(0,14);
            Zawód.Text = lines[5].Remove(0,7);
            TrybŻycia.Text = lines[6].Remove(0,12);
            MasaCiała.Text = lines[7].Remove(0,12);
            Wzrost.Text = lines[8].Remove(0,8);
            ObwBioder.Text = lines[9].Remove(0,14);
            ObwTalii.Text = lines[10].Remove(0,13);
            Box12.Text = lines[11].Remove(0,20);
            button1.Text = lines[12].Remove(0, 5);
            Płeć.Text = lines[13].Remove(0, 6);
        }

        private void wyczyśćToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Imie.Clear();
            Nazwisko.Clear();
            Wiek.Clear();
            NumerTelefonu.Clear();
            Email.Clear();
            Zawód.Clear();
            TrybŻycia.ResetText();
            MasaCiała.Clear();
            Wzrost.Clear();
            ObwBioder.Clear();
            ObwTalii.Clear();
            Box12.ResetText();
            button1.ResetText();
            Płeć.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double BMI;
            BMI = Convert.ToDouble(MasaCiała.Text) / ((Convert.ToDouble(Wzrost.Text))*(Convert.ToDouble(Wzrost.Text))/10000);
            button1.Text = Convert.ToString(BMI);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A;
            A = 66.5 + (13.7 * Convert.ToDouble(MasaCiała.Text) + (5 * Convert.ToDouble(Wzrost.Text)) - (6.8 * Convert.ToDouble(Wiek.Text)));
            double B;
            B = Convert.ToDouble(TrybŻycia.Text);
            double C;
            C = A * B;
            button2.Text = Convert.ToString(C) + "kcal";
            

        }

        private void Box12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
