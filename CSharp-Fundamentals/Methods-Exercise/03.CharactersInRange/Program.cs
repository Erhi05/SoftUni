namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            if (firstChar > secondChar)
            {
                char swap = firstChar;
                firstChar = secondChar;
                secondChar = swap;
            }

            PrintCharactersInRange(firstChar, secondChar);
        }

        private static void PrintCharactersInRange(char firstChar, char secondChar)
        {
            for (char i = (char)(firstChar + 1); i < secondChar; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
