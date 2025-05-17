namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateArea(width, height));
        }

        private static double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
