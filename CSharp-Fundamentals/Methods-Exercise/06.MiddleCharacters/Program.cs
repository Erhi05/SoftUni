using static System.Net.Mime.MediaTypeNames;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetMiddleChars(input));
        }

        private static string GetMiddleChars(string? input)
        {
            int middleIndex = input.Length / 2;

            string result = $"{input[middleIndex]}";

            if (input.Length % 2 == 0)
            {
                result = $"{input[middleIndex - 1]}" + result;
            }

            return result;
        }
    }
}
