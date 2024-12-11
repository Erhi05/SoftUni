namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                switch (currentChar)
                {
                    case 'a':
                        totalValue += 1;
                        break;
                    case 'e':
                        totalValue += 2;
                        break;
                    case 'i':
                        totalValue += 3;
                        break;
                    case 'o':
                        totalValue += 4;
                        break;
                    case 'u':
                        totalValue += 5;
                        break;
                }
            }

            Console.WriteLine(totalValue);
        }
    }
}
