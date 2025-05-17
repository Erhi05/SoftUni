namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Power(number, power));
        }

        private static double Power(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
