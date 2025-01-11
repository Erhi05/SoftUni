namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int product = n * i;
                    Console.WriteLine($"{n} X {i} = {product}");
                }
            }
            else
            {
                int product = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {product}");
            }
        }
    }
}
