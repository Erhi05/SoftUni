using System.Globalization;

namespace _13.HolidaysBetweenTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy",
                CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy",
                CultureInfo.InvariantCulture);

            // Initialize holiday count
            int holidaysCount = 0;

            // Use date <= endDate and correct date increment
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Check if the day is Saturday or Sunday
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
