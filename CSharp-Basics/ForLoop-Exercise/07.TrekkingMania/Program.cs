namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            int total = 0;

            for (int group = 1; group <= n; group++)
            {
                int count = int.Parse(Console.ReadLine());
                total += count;

                if (count <= 5)
                    countP1 += count;
                else if (count <= 12)
                    countP2 += count;
                else if (count <= 25)
                    countP3 += count;
                else if (count <= 40)
                    countP4 += count;
                else
                    countP5 += count;
            }

            Console.WriteLine($"{(double)countP1 / total * 100:f2}%");
            Console.WriteLine($"{(double)countP2 / total * 100:f2}%");
            Console.WriteLine($"{(double)countP3 / total * 100:f2}%");
            Console.WriteLine($"{(double)countP4 / total * 100:f2}%");
            Console.WriteLine($"{(double)countP5 / total * 100:f2}%");
        }
    }
}
