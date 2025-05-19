using System.Collections.Generic;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(firstNum) / Factorial(secondNum)):f2}");
        }

        private static double Factorial(long num)
        {
            double result = num;

            for (long i = num - 1; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
