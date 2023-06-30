using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegowanie_zadań_do_funkcji_nr_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int seconds = 332;

            string formattedTime = FormatTime(seconds);
            Console.WriteLine(formattedTime);
            Console.ReadLine();

        }

        static string FormatTime(int seconds)
        {
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;

            return hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + remainingSeconds.ToString("D2");
        }
    }
}
