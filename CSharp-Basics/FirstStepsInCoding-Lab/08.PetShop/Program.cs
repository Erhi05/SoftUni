namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double expenses = dogFood * 2.5 + catFood * 4;

            Console.WriteLine($"{expenses} lv.");
        }
    }
}
