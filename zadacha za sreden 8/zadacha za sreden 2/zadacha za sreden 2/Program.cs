using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete radius:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Vuvedete visochina:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("vuvedete diametur");
            double diametur = double.Parse(Console.ReadLine());

            double v = (Math.PI * (radius * radius) * height);
            Console.WriteLine("V="+(v));
            double s = (2*(Math.PI* radius * height));
            Console.WriteLine("S="+(s));
            double b = (Math.PI*(radius * radius));
            double s1 = ((2 * b) + s);
            Console.WriteLine("s1="+(s1));

        }
    }
}
