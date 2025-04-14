namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] reversedStrings = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                reversedStrings[i] = strings[strings.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedStrings));
        }
    }
}
