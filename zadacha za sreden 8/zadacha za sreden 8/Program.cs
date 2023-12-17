using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCount = 0;
            int negativeCount = 0;
            Console.WriteLine("vuvedete celi chisla za da prikluchite vuvejdaneto, vuvedete 0");
            while (true)
            {
                Console.Write("vuvedete chislo:");
                if (int.TryParse(Console.ReadLine(),out int inputNumber))
                {
                    if (inputNumber==0)
                    {
                        break;
                    }
                    totalCount++;
                    if (inputNumber < 0)
                    {
                        negativeCount++;
                    }
                }
                else
                {
                    Console.WriteLine("Nevalidno chislo. Molqvuvedete otnoto");
                }
               
            }
            Console.WriteLine($"obsht broi vuvedeni chisla: {totalCount}");
            Console.WriteLine($"obsht otricatelni chisla: {negativeCount}");

        }
    }
}
