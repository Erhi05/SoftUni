namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double shoes = yearTax - yearTax * 0.4;
            double clothes = shoes - shoes * 0.2;
            double ball = clothes / 4;
            double acc = ball / 5;

            double allSum = yearTax + shoes + clothes + ball + acc;

            Console.WriteLine(allSum);
        }
    }
}
