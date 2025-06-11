namespace _02.ChangeList
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
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split();
                if (commandParts[0] == "Delete")
                {
                    int numberToDelete = int.Parse(commandParts[1]);
                    numbers.RemoveAll(n => n == numberToDelete);
                }
                else if (commandParts[0] == "Insert")
                {
                    int numberToInsert = int.Parse(commandParts[1]);
                    int index = int.Parse(commandParts[2]);
                    numbers.Insert(index, numberToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
