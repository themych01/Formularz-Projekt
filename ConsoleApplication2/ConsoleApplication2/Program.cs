using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> wartosci = new Stack<string>();

            wartosci.Push("Pierwsza");

            wartosci.Push("Druga");
            wartosci.Push("Trzecia");

            while (wartosci.Count > 0)
            {
                string wartosc = wartosci.Pop();
                Console.WriteLine(wartosc);
            }
            Stack<operacja> operacje = new Stack<operacja>();
            operacje.Push(new operacja("Operacja 1"));
            operacje.Push(new operacja("Operacja 2"));
            operacje.Push(new operacja("Operacja 3"));
            operacje.Push(new operacja("Operacja 4"));

            while ( operacje.Count >0)
            {
                operacja operacje = operacje.Pop();
                operacje.Wykonaj();
            }
            Console.ReadKey();
        }
    }
}
