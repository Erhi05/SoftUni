namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int newNumber = int.Parse(input);

                if (newNumber < minNumber)
                {
                    minNumber = newNumber;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
