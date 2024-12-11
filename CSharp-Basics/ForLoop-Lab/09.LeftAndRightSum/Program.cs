namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                left += newNumber;
            }

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                right += newNumber;
            }

            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                int difference = Math.Abs(right - left);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
