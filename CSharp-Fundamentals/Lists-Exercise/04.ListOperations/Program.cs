namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandParts = command.Split();
                switch (commandParts[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(commandParts[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(commandParts[1]);
                        int index = int.Parse(commandParts[2]);
                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(commandParts[1]);
                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (commandParts[1] == "left")
                        {
                            int countLeft = int.Parse(commandParts[2]);
                            for (int i = 0; i < countLeft; i++)
                            {
                                int firstElement = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstElement);
                            }
                        }
                        else if (commandParts[1] == "right")
                        {
                            int countRight = int.Parse(commandParts[2]);
                            for (int i = 0; i < countRight; i++)
                            {
                                int lastElement = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, lastElement);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
