namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double kilometers = number / 1000.0;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
