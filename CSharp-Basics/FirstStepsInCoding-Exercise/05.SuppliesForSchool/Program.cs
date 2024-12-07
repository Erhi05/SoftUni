namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double penSum = pencils * 5.80;
            double markerSum = markers * 7.20;
            double litersSum = liters * 1.20;

            double allMaterials = penSum + markerSum + litersSum;
            double finalSum = allMaterials - (allMaterials * discount / 100);

            Console.WriteLine(finalSum);
        }
    }
}
