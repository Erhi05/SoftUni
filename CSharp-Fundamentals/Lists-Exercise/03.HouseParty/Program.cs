namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < guestCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];

                if (command[2] == "going!")
                {
                    AddGuest(guestList, name);
                }
                else if (command[2] == "not")
                {
                    RemoveGuest(guestList, name);
                }
            }

            Console.WriteLine(string.Join("\n", guestList));
        }

        private static void RemoveGuest(List<string> guestList, string name)
        {
            if (!guestList.Contains(name))
            {
                Console.WriteLine($"{name} is not in the list!");
            }
            else
            {
                guestList.Remove(name);
            }
        }

        private static void AddGuest(List<string> guestList, string name)
        {
            if (guestList.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
            }
            else
            {
                guestList.Add(name);
            }
        }
    }
}
