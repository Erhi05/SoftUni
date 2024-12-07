namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int timeOfMovie = int.Parse(Console.ReadLine());
            int timeOfBreak = int.Parse(Console.ReadLine());

            double timeForLunch = timeOfBreak / 8.0;
            double timeForRest = timeOfBreak / 4.0;

            double allTimeNeeded = timeOfMovie + timeForLunch + timeForRest;

            double diffrence = Math.Abs(allTimeNeeded - timeOfBreak);

            if (allTimeNeeded <= timeOfBreak)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(diffrence)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(diffrence)} more minutes.");
            }
        }
    }
}
