namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double secondsInOneMeter = double.Parse(Console.ReadLine());

            double timeForSwim = distanceInMeters * secondsInOneMeter;
            double timesDelay = Math.Floor(distanceInMeters / 15);
            double finalTime = timeForSwim + timesDelay * 12.5;

            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
            }
            else
            {
                double neededTime = finalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
            }
        }
    }
}
