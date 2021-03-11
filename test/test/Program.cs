using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Niezbednik nzb = new Niezbednik();

            Console.WriteLine("Podaj a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wieksza jest liczba " + nzb.Wieksza(a, b) + "\n\n");
            Console.WriteLine("Stare a = " + a + "\nStare b = " + b + "\n\n");

            nzb.Zamien(ref a, ref b);

            Console.WriteLine("Po zamianie: \na = " + a + "\nb = " + b + "\n\n");

            try
            {
                Int32 a_ = Convert.ToInt32(a);
                Int32 sil = nzb.Silnia(a_);

                if (sil == -1)
                {
                    throw new StackOverflowException();
                }

                Console.WriteLine("Silnia liczby a (po zamianie) wynosi " + nzb.Silnia(a_));
                Console.WriteLine("\nTa sama silnia liczona rekurencyjnie wynosi " + nzb.RekurencyjnaSilnia(a_));
            }
            catch (System.StackOverflowException)
            {
                Console.WriteLine("Blad przepelnienia. Nie oblicze silni z tej liczby.\n");
            }

            Console.ReadKey();
        }
    }
}
