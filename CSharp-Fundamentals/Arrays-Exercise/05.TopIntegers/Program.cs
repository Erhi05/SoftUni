namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int[] numbers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
