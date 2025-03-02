namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            int sum = 0;

            while (digit > 0)
            {
                sum += digit % 10;
                digit /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
