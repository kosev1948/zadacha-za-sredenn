using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_za_sreden_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedete chisla razdeleni s intervali");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            foreach (int number in numbers)
            {
                Console.WriteLine($"za chisloto{number}: {CheckNumber(number)}");
            }
            Console.WriteLine("spisuk ot prostite chisla:");
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    Console.Write(number+"");
                }
            }
            Console.WriteLine("\nSpisuk ot chetni chisla:");
            foreach (int number in numbers)
            {
                if (IsOdd(number))
                {
                    Console.Write(number+ " ");
                }

            }

        }
        static string CheckNumber(int number)
        {
            if (IsPrime(number))
            {
                return "chisloto e prosto";
            }
            else if (IsOdd(number))
            {
                return "chisloto ne e prosto no e chetno";
            }
            else
            {
                return "Chisloto NE e prosto u NE e chetno";
            }
        }
        static bool IsPrime(int number)
        {
            if (number<2)
            {
                return false;
            }
            for (int i = 2; i<=Math.Sqrt(number);i++ )
            {
                if (number% i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

    }
}
