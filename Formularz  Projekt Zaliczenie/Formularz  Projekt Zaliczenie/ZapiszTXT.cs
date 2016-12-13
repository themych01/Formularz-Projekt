using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularz__Projekt_Zaliczenie
{
    class ZapiszTXT
    {
        public void Zapisz()
        {
            string[] lines = { };
            System.IO.File.WriteAllLines(@"C:\Users\Public\PlikiTekstoweFormularza\Osoby.txt", lines);
        }
    }
}
