using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zafacha_za_sreden_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Console.WriteLine("vuvedete 20 celi chisla:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Element{i +1}:");
                if (int.TryParse(Console.ReadLine(),out int inputNumber))
                {
                    numbers[1] = inputNumber;
                }
                else
                {
                    Console.WriteLine("Nevalidno chislo vuvedete otnovo");
                    i--;
                }
            }
            int sumOfNonZero = 0;
            int zeroCount = 0;
            foreach (int number in numbers)
            {
                if (number !=0)
                {
                    sumOfNonZero += number;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine($"Sumata na nenulevite elemnti e:{sumOfNonZero}");
            Console.WriteLine($"Broi na nulite v masiva e: {zeroCount}");
        }
    }
}
