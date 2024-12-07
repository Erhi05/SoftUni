namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegi = int.Parse(Console.ReadLine());

            double chinkenSum = chicken * 10.35;
            double fishSum = fish * 12.40;
            double vegiSum = vegi * 8.15;

            double orderPrice = chinkenSum + fishSum + vegiSum;

            double desert = orderPrice * 0.2;

            double delivery = 2.50;

            double fullPrice = orderPrice + desert + delivery;

            Console.WriteLine(fullPrice);
        }
    }
}
