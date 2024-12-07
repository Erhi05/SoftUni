namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int proccesor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int sumOfVideoCard = videoCard * 250;
            double sumOfProccesor = proccesor * sumOfVideoCard * 0.35;
            double sumOfRam = ram * sumOfVideoCard * 0.1;

            double finalSum = sumOfVideoCard + sumOfProccesor + sumOfRam;

            if (videoCard > proccesor)
            {
                finalSum *= 0.85;
            }

            if (budget >= finalSum)
            {
                double leftMoney = budget - finalSum;
                Console.WriteLine($"You have {leftMoney:F2} leva left!");
            }
            else
            {
                double neededMoney = finalSum - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
            }
        }
    }
}
