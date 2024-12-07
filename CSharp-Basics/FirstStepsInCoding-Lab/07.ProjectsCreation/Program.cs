namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int timeNeeded = projectsCount * 3;

            Console.WriteLine($"The architect {name} will need {timeNeeded} hours to complete {projectsCount} project/s.");
        }
    }
}
