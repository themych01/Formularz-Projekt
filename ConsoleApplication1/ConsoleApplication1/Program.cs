using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void main()
        {
            try
            {
                Console.WriteLine(ObliczPierwiastek(16));
                Console.WriteLine(ObliczPierwiastek(-16));
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine("Wystąpił wyjątek");
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine("To nie mogło wyjść");
            }


            public static double ObliczPierwiastek(double x)
        {
            x = -1;
            if (x < 0)
            {
                throw new ArithmeticException("Nie można pierwiastkować liczby ujemnej");

            }
            return Math.Sqrt(x);
            Console.ReadKey();
        }
    }
    }
}
