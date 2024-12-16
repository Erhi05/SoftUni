namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int starterPoints = int.Parse(Console.ReadLine());

            int pointsFromTournaments = 0;
            int wins = 0;

            for (int i = 1; i <= tournaments; i++)
            {
                string state = Console.ReadLine();

                if (state == "W")
                {
                    pointsFromTournaments += 2000;
                    wins++;
                }
                else if (state == "SF")
                {
                    pointsFromTournaments += 720;
                }
                else if(state == "F")
                {
                    pointsFromTournaments += 1200;
                }
            }

            double averagePoints = Math.Floor((double)pointsFromTournaments / tournaments);

            double winPerecent = (double)wins / tournaments * 100.0;

            Console.WriteLine($"Final points: { pointsFromTournaments + starterPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{winPerecent:F2}%");
        }
    }
}
