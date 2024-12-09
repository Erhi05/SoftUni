namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalCost = 0;

            switch (flowerType)
            {
                case "Roses":
                    totalCost = flowerCount * 5.0;
                    if (flowerCount > 80)
                        totalCost *= 0.9;
                    break;
                case "Dahlias":
                    totalCost = flowerCount * 3.80;
                    if (flowerCount > 90)
                        totalCost *= 0.85;
                    break;
                case "Tulips":
                    totalCost = flowerCount * 2.80;
                    if (flowerCount > 80)
                        totalCost *= 0.85;
                    break;
                case "Narcissus":
                    totalCost = flowerCount * 3.0;
                    if (flowerCount < 120)
                        totalCost *= 1.15;
                    break;
                case "Gladiolus":
                    totalCost = flowerCount * 2.50;
                    if (flowerCount < 80)
                        totalCost *= 1.20;
                    break;
            }

            double remainingBudget = budget - totalCost;

            if (remainingBudget >= 0)
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {remainingBudget:F2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {Math.Abs(remainingBudget):F2} leva more.");
        }
    }
}
