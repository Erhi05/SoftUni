namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] commandParts = command.Split(":");
                string action = commandParts[0];
                string courseName = commandParts[1];
                switch (action)
                {
                    case "Add":
                        if (!courses.Contains(courseName))
                        {
                            courses.Add(courseName);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(commandParts[2]);
                        if (!courses.Contains(courseName) && index >= 0 && index < courses.Count)
                        {
                            courses.Insert(index, courseName);
                        }
                        break;
                    case "Remove":
                        courses.Remove(courseName);
                        break;
                    case "Swap":
                        string secondCourse = commandParts[2];
                        if (courses.Contains(courseName) && courses.Contains(secondCourse))
                        {
                            int firstIndex = courses.IndexOf(courseName);
                            int secondIndex = courses.IndexOf(secondCourse);
                            courses[firstIndex] = secondCourse;
                            courses[secondIndex] = courseName;
                            if (courses.Contains($"{courseName}-Exercise"))
                            {
                                courses.Remove($"{courseName}-Exercise");
                                courses.Insert(secondIndex + 1, $"{courseName}-Exercise");
                            }
                            if (courses.Contains($"{secondCourse}-Exercise"))
                            {
                                courses.Remove($"{secondCourse}-Exercise");
                                courses.Insert(firstIndex + 1, $"{secondCourse}-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        if (!courses.Contains(courseName))
                        {
                            courses.Add(courseName);
                            courses.Add($"{courseName}-Exercise");
                        }
                        else if (!courses.Contains($"{courseName}-Exercise"))
                        {
                            int courseIndex = courses.IndexOf(courseName);
                            courses.Insert(courseIndex + 1, $"{courseName}-Exercise");
                        }
                        break;
                }
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
