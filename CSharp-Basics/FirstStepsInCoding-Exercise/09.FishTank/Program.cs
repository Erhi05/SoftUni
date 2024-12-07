namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double volumeLiters = volume * 0.001;
            double others = percent / 100.0;

            double waterNeeded = volumeLiters * (1 - others);

            Console.WriteLine(waterNeeded);
        }
    }
}
