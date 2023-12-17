using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete polojitelno 3-cifreno chislo:");
            int number = int.Parse(Console.ReadLine());

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;
            Console.WriteLine($"Cifrata na stoticite:{hundreds}");
            Console.WriteLine($"Cifrata na deseticite:{tens}");
            Console.WriteLine($"cifrata na edinicite:{units}");
        }
    }
}
