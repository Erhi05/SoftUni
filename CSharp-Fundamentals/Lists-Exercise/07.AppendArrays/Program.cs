namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                            .Split('|')
                            .ToList();

            List<int> result = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<int> currentNumbers = input[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                result.AddRange(currentNumbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
