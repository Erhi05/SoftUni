namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNumber = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
