namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int add = Add(firstNum, secondNum);
            int sub = Sub(add, thirdNum);

            Console.WriteLine(sub);
        }

        private static int Sub(int add, int thirdNum)
        {
            return add - thirdNum;
        }

        private static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
