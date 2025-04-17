namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxCount = 0;
            int currentCount = 1;
            int startIndex = 0;
            int bestStartIndex = 0;
            int bestEndIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        bestStartIndex = startIndex;
                        bestEndIndex = i;
                    }
                }
                else
                {
                    currentCount = 1;
                    startIndex = i;
                }
            }

            if (maxCount > 0)
            {
                for (int i = bestStartIndex; i <= bestEndIndex; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
