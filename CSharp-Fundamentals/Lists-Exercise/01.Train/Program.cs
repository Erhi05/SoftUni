namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split();
                if (commandParts[0] == "Add")
                {
                    int newWagon = int.Parse(commandParts[1]);
                    Array.Resize(ref wagons, wagons.Length + 1);
                    wagons[wagons.Length - 1] = newWagon;
                }
                else
                {
                    int passengers = int.Parse(commandParts[0]);
                    for (int i = 0; i < wagons.Length; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
