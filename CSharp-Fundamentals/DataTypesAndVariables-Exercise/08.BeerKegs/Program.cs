﻿namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string biggestKegModel = "";
            double biggestKeg = 0;

            int kegsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                double kegHeight = double.Parse(Console.ReadLine());

                double volume = Math.PI * (kegRadius * kegRadius) * kegHeight;

                if (biggestKeg < volume)
                {
                    biggestKeg = volume;
                    biggestKegModel = kegModel;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
