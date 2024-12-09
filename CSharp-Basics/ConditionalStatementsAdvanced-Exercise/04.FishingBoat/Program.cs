namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rent = 0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                    rent = 4200;
                    break;
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;
            }

            if (fishermen <= 6)
            {
                rent *= 0.9;
            }
            else if (fishermen <= 11)
            {
                rent *= 0.85;
            }
            else
            {
                rent *= 0.75;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }

            double remainingBudget = budget - rent;

            if (remainingBudget >= 0)
            {
                Console.WriteLine($"Yes! You have {remainingBudget:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(remainingBudget):F2} leva.");
            }
        }
    }
}
