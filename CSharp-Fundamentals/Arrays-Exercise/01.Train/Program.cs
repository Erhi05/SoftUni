namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int[] wagon = new int[n];

            for (int i = 0; i < n; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
                total += wagon[i];
            }

            Console.WriteLine(string.Join(" ", wagon));
            Console.WriteLine(total);


        }
    }
}
