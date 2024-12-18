namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string input = Console.ReadLine();
                int maxNumber = int.MinValue;

                while (input != "Stop")
                {
                    int newNumber = int.Parse(input);

                    if (newNumber > maxNumber)
                    { 
                        maxNumber = newNumber;
                    }

                    input = Console.ReadLine();
                }
                Console.WriteLine(maxNumber);
        }
    }
}
