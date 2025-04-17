namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firsArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            for (int j = 0; j < secondArr.Length; j++)
            {
                for (int i = 0; i < firsArr.Length; i++)
                {
                    if (firsArr[i] == secondArr[j])
                    {
                        Console.Write($"{firsArr[i]} ");
                        break;
                    }
                }
            }
        }
    }
}
