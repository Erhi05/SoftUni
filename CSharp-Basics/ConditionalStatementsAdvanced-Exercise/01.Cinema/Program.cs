namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (projection == "Premiere")
            {
                income = r * c * 12;
            }
            else if (projection == "Normal")
            {
                income = r * c * 7.50;
            }
            else if (projection == "Discount")
            {
                income = r * c * 5;
            }

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
