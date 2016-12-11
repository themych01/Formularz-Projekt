using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Formularz_Projekt
{
    public class MainForm : Form
    {
        private Button button1 = new Button();
        private Label label1 = new Label();
        private TextBox textbox1 = new TextBox();




        private void nowy(object sender, EventArgs ea)
        {
            label1.Text = textbox1.Text;
        }
        private Label label = new Label();




        private void NowyOsobaMężczyzna(object sender, EventArgs ea)
        {
            MessageBox.Show("Zaczynamy dodawać nową osobe", "Komunikat");
        }


        private void NowyOsobaKobieta(object sender, EventArgs ea)
        {
            MessageBox.Show("Zaczynamy dodawać nową osobe", "Komunikat");
        }


        private void Zakończ(object sender, EventArgs ea)
        {
            Application.Exit();
        }



        public MainForm()
        {
            System.Drawing.Bitmap bitmap1 = Formularz_Projekt.Properties.Resources.piramidazywienia_2009_2016;
            Text = " Formularz ";
            Width = 1024;
            Height = 750;

            PictureBox pb = new PictureBox();
            pb.Image = bitmap1;
            pb.Width = 1024;
            pb.Height = 720;

            pb.Dock = DockStyle.Fill;
            this.Controls.Add(pb);
  

            MainMenu mm = new MainMenu();
            MenuItem mi1 = new MenuItem("Nowy");
            MenuItem mi2 = new MenuItem("Edytuj");

            MenuItem m1p1 = new MenuItem("Osoba");
            MenuItem mi3 = new MenuItem("Zakończ");

            MenuItem m1p1p1 = new MenuItem("Mężczyzna");
            MenuItem m1p1p2 = new MenuItem("Kobieta");

            m1p1.MenuItems.Add(m1p1p1);
            m1p1.MenuItems.Add(m1p1p2);

            mi1.MenuItems.Add(m1p1);


            mm.MenuItems.Add(mi1);
            mm.MenuItems.Add(mi2);
            mm.MenuItems.Add(mi3);

            mi3.Click += new EventHandler(Zakończ);
            m1p1p1.Click += new EventHandler(NowyOsobaMężczyzna);
            m1p1p2.Click += new EventHandler(NowyOsobaKobieta);

            Menu = mm;
         //   Application.ApplicationExit += new EventHandler(OnExit);

        }
       // private void OnExit(Object sender, EventArgs ea)
       // {
       //     MessageBox.Show("Do widzenia!");
       // }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //MessageBox.Show("Witam, Zapraszam do Używania Programu","Powitanie");
            Application.Run(new MainForm());
            
            //Osoba klient1 = new Osoba("Paweł", "Gnyszka", 22, 86.5, 1.85, 791549953, "asdasd", "student", "student", 105, 95);
            //klient1.WyliczBMI();
            //klient1.WypiszInfo();
            
        }
    }
}
