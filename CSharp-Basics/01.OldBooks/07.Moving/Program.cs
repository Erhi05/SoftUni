namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int space = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            int boxes = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{space} Cubic meters left.");
                    break;
                }

                int cartonsCount = int.Parse(input);
                boxes += cartonsCount;

                int occupiedVolume = cartonsCount * 1 * 1 * 1;
                space -= occupiedVolume;

                if (space < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
                    return;
                }
            }
        }
    }
}
