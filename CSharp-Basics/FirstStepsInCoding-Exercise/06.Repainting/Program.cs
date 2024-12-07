namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nailonSum = (nailon + 2) * 1.50;
            double paintSum = ((paint * paint * 0.1) * 14.50);
            double razreditelSum = razreditel * 5.00;
            double torbitcka = 0.40;

            double allSum = nailonSum + paintSum + razreditelSum + torbitcka;

            double workers = (allSum * 0.3) * hours;

            double finalSum = allSum + workers;

            Console.WriteLine(finalSum);

        }
    }
}
