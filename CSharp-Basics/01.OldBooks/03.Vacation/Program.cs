namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedModey = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (ownedModey < neededMoney && spendingCounter < 5)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    if (money > ownedModey)
                    {
                        ownedModey = 0;
                    }
                    else
                    {
                        ownedModey -= money;
                    }
                    spendingCounter++;
                }
                else if (input == "save")
                {
                    ownedModey += money;
                    spendingCounter = 0;
                }

                daysCounter++;
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
