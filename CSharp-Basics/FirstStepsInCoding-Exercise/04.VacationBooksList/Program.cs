namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int sum = pagesCount / pagesPerHour / days;

            Console.WriteLine(sum);
        }
    }
}
