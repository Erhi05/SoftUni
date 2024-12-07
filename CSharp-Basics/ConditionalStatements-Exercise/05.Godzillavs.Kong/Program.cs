namespace _05.Godzillavs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistics = int .Parse(Console.ReadLine());
            double dressForOneStat = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double dress = statistics * dressForOneStat;

            if (statistics > 150)
            {
                dress *= 0.9;
            }

            double filmSum = decor + dress;

            if (filmSum > budget)
            {
                double nedeedMoney = filmSum - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {nedeedMoney:F2} leva more.");
            }
            else if (filmSum <= budget)
            {
                double leftMoney = budget - filmSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
        }
    }
}
