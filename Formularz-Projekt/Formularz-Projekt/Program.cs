using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba klient1 = new Osoba("Paweł", "Gnyszka", 22, 86.5, 1.85, 791549953, "asdasd", "student", "student", 105, 95);
            klient1.WyliczBMI();
            klient1.WypiszInfo();
            
        }
    }
}
