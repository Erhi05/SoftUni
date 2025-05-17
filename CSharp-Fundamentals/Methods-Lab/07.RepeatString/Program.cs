﻿namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(text, count));
        }

        private static string RepeatedString(string text, int count)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result += text;
            }
            return result;
        }
    }
}
