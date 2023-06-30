using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegowanie_zadań_do_funkcji_nr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2.5;
            double y1 = 3.7;
            double x2 = -1.8;
            double y2 = 4.2;

            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine("Długość odcinka: " + distance);
            Console.ReadKey();
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
