using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegowanie_zadań_do_funkcji_nr_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int primeDivisors = CountPrimeDivisors(n);
            Console.WriteLine("Liczba dzielników, które są liczbami pierwszymi: " + primeDivisors);
        }

        static int CountPrimeDivisors(int n)
        {
            if (n <= 5)
            {
                return 0;
            }

            int count = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0 && IsPrime(i))
                {
                    count++;
                }
            }

            return count;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
