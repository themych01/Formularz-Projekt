using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz_Projekt
{
    public class MainForm : Form
    {
        public MainForm()
        {
            Text = " Formularz ";
            Width = 960;
            Height = 600;

            MainMenu mm = new MainMenu();
            MenuItem mi1 = new MenuItem("Nowy");
            MenuItem mi2 = new MenuItem("Edytuj");

            MenuItem m1p1 = new MenuItem("Osoba");

            MenuItem m1p1p1 = new MenuItem("Mężczyzna");
            MenuItem m1p1p2 = new MenuItem("Kobieta");

            m1p1.MenuItems.Add(m1p1p1);
            m1p1.MenuItems.Add(m1p1p2);

            mi1.MenuItems.Add(m1p1);


            mm.MenuItems.Add(mi1);
            mm.MenuItems.Add(mi2);

            Menu = mm;

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MainForm());
            Osoba klient1 = new Osoba("Paweł", "Gnyszka", 22, 86.5, 1.85, 791549953, "asdasd", "student", "student", 105, 95);
            klient1.WyliczBMI();
            klient1.WypiszInfo();
            
        }
    }
}
