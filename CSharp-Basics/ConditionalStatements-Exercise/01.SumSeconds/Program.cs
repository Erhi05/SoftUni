namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstTime = int.Parse(Console.ReadLine());
            int SecondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());

            int total = FirstTime + SecondTime + ThirdTime;

            int minutes = total / 60;
            int seconds = total % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
