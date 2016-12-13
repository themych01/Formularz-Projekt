using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class operacja
    {
        private readonly string nazwaOperacji;
        public operacja(string nazwaOperacji)
        {
            this.nazwaOperacji = nazwaOperacji;
        }
        public void Wykonaj()
        {
            Console.WriteLine("Wykonanie operacji : " + nazwaOperacji);
        }

         
    }
}
