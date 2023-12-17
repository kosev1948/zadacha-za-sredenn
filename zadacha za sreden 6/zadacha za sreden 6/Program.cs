using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete stoinostite za purvi chlen razlika i nomer na posleden chlen:");
            int firstTerm = int.Parse(Console.ReadLine());
            int difference = int.Parse(Console.ReadLine());
            int lastTermNumber = int.Parse(Console.ReadLine());

            int sum = (2 * firstTerm + (lastTermNumber - 1) * difference) * lastTermNumber / 2;

            int middleTerm = firstTerm + (lastTermNumber - 1) / 2 * difference;
            Console.WriteLine($"Redicata:{GetAritmeticProgression(firstTerm, difference, lastTermNumber)}");
            Console.WriteLine($"suma na purvite{lastTermNumber} chlena:{sum}");
            if (middleTerm % 2 == 0)
            {
                int averageOfmiddleTerms = (middleTerm + middleTerm - difference) / 2;
                Console.WriteLine($"sreden chlen v redicata:{middleTerm}, sredno aritmeticno na srednite chlenove:{averageOfmiddleTerms}");

            }
            else
            {
                Console.WriteLine($"sreden chlen v redicata:{middleTerm}");
            }
        }
        static string GetAritmeticProgression(int firstTerm, int difference, int lastTermNumber)
        {
            int[] progression = new int[lastTermNumber];
            for (int i = 0; i < lastTermNumber; i++)
            {
                progression[1] = firstTerm + i * difference;
            }
            return string.Join(",", progression);
        }
    }
}
