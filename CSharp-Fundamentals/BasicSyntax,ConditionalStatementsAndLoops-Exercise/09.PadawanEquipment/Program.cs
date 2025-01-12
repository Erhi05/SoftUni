namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double percent = studentsCount * 0.1;
            double allSabers = studentsCount + Math.Ceiling(percent);
            double sabers = saberPrice * allSabers;

            double robes = robePrice * studentsCount;

            double beltsDiscount = studentsCount - Math.Ceiling((double)(studentsCount / 6));
            double belts = beltPrice * beltsDiscount;

            double total = sabers + robes + belts;
            
            Console.WriteLine(total <= moneyAmount ?
                $"The money is enough - it would cost {total:F2}lv." :
                $"John will need {(total - moneyAmount):F2}lv more.");
        }
    }
}
