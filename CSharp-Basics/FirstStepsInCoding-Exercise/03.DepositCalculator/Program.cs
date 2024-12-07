namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double taxes = double.Parse(Console.ReadLine()) / 100;

            double sum = deposit + months * (deposit * taxes / 12);

            Console.WriteLine(sum);
        }
    }
}
