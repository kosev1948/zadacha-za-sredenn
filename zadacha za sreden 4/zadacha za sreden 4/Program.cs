using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete chisla, razdeleni s intervali");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);
            string result = string.Join("<",numbers);
            Console.WriteLine(result);
        }
    }
}
