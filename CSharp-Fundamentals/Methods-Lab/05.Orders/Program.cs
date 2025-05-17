namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    PrintPrice(quantity * 1.50);
                    break;
                case "water":
                    PrintPrice(quantity * 1.00);
                    break;
                case "coke":
                    PrintPrice(quantity * 1.40);
                    break;
                case "snacks":
                    PrintPrice(quantity * 2.00);
                    break;
            }
        }

        private static void PrintPrice(double quantity)
        {
            Console.WriteLine($"{quantity:F2}");
        }
    }
}
