namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deposit = Console.ReadLine();
            double totalSum = 0;

            while (deposit != "NoMoreMoney")
            {
                double currentInput = double.Parse(deposit);

                if (currentInput < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                totalSum += currentInput;
                Console.WriteLine($"Increase: {currentInput:F2}");

                deposit = Console.ReadLine();
            }

            Console.WriteLine($"Total: {totalSum:F2}");
        }
    }
}
