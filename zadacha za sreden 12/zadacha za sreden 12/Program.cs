using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi duma:");
            string vhod = Console.ReadLine();
            string ogledalnaDuma = Ogledalnaduma(vhod);
            Console.WriteLine("Ogledalno:" + ogledalnaDuma);
        }
        static string Ogledalnaduma(string duma)
        {
            char[] simvoli = duma.ToCharArray();
            Array.Reverse(simvoli);
            return new string(simvoli);
        }
    }
}
