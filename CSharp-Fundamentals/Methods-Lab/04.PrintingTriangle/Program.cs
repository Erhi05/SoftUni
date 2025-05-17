namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        private static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
