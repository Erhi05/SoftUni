namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int countOfPuzzels = int.Parse(Console.ReadLine());
            int countOfDolls = int.Parse(Console.ReadLine());
            int countOfBears = int.Parse(Console.ReadLine());
            int countOfMinions = int.Parse(Console.ReadLine());
            int countOfTrucks = int.Parse(Console.ReadLine());

            double priceOfPuzzels = countOfPuzzels * 2.6;
            double priceOfDolls = countOfDolls * 3;
            double priceOfBears = countOfBears * 4.1;
            double priceOfMinions = countOfMinions * 8.2;
            double priceOfTrucks = countOfTrucks * 2;

            int countOfAll = countOfPuzzels + countOfDolls + countOfBears + countOfMinions + countOfTrucks;
            double priceOfAll = priceOfPuzzels + priceOfDolls + priceOfBears + priceOfMinions + priceOfTrucks;

            if (countOfAll >= 50)
            {
                priceOfAll *= 0.75;
            }

            double rent = priceOfAll * 0.1;

            double finalPrice = priceOfAll - rent;

            if (finalPrice >= priceOfTrip)
            {
                double moneyLeft = finalPrice - priceOfTrip;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyNeeded = priceOfTrip - finalPrice;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
