namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                total += newNumber;
            }

            Console.WriteLine(total);
        }
    }
}
