namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedProblems = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblemsCount = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedProblems)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedProblemsCount++;
                lastProblem = problemName;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
