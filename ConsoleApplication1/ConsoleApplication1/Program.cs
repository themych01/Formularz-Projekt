using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public delegate int Delegacja(int arg1, int arg2);
        public static int Metoda1(int argument1 , int argument2)
        {
            int wynik = argument1 + argument2;
            return wynik;
        }
        public static void Metoda2(string napis)
        {
            Console.WriteLine("Została wywołana metoda2");
        }
        static void Main(string[] args)
        {
            Delegacja del1 = Metoda1;
            int wartosc = del1(4, 8);
            Console.WriteLine(wartosc);
            Console.ReadKey();
        }
    }
}
