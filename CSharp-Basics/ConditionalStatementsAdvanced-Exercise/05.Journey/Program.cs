namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string season = Console.ReadLine();

            string destination;
            switch (budget)
            {
                case double b when b <= 100:
                    destination = "Bulgaria";
                    break;
                case double b when b <= 1000:
                    destination = "Balkans";
                    break;
                default:
                    destination = "Europe";
                    break;
            }

            double spentAmount;
            string vacationType;
            switch (destination)
            {
                case "Bulgaria":
                    switch (season)
                    {
                        case "summer":
                            vacationType = "Camp";
                            spentAmount = budget * 0.3;
                            break;
                        case "winter":
                            vacationType = "Hotel";
                            spentAmount = budget * 0.7;
                            break;
                        default:
                            Console.WriteLine("Invalid season entered.");
                            return;
                    }
                    break;
                case "Balkans":
                    switch (season)
                    {
                        case "summer":
                            vacationType = "Camp";
                            spentAmount = budget * 0.4;
                            break;
                        case "winter":
                            vacationType = "Hotel";
                            spentAmount = budget * 0.8;
                            break;
                        default:
                            Console.WriteLine("Invalid season entered.");
                            return;
                    }
                    break;
                case "Europe":
                    vacationType = "Hotel";
                    spentAmount = budget * 0.9;
                    break;
                default:
                    Console.WriteLine("Invalid destination calculated.");
                    return;
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:F2}", vacationType, spentAmount);
        }
    }
}
