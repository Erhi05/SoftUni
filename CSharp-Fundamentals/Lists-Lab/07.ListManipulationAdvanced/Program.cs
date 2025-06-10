namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool hasChanges = false;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split();
                string action = commandParts[0];
                switch (action)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        numbers.Add(numberToAdd);
                        hasChanges = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(commandParts[1]);
                        numbers.Remove(numberToRemove);
                        hasChanges = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(commandParts[1]);
                        numbers.RemoveAt(indexToRemove);
                        hasChanges = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int indexToInsert = int.Parse(commandParts[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        hasChanges = true;
                        break;
                    case "Contains":
                        int numberToCheck = int.Parse(commandParts[1]);
                        Console.WriteLine(numbers.Contains(numberToCheck) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = commandParts[1];
                        int filterNumber = int.Parse(commandParts[2]);

                        if (condition == "<")
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < filterNumber)));
                        else if (condition == ">")
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > filterNumber)));
                        else if (condition == "<=")
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= filterNumber)));
                        else if (condition == ">=")
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= filterNumber)));
                        break;
                }
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
