namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          Sofia   5 %       7 %     8 %       12 %
            //          Varna   4.5 %     7.5 %   10 %      13 %
            //          Plovdiv 5.5 %     8 %     12 %      14.5 %

            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;

            if (sales >= 0)
            {
                switch (city)
                {
                    case "Sofia":
                        if (sales >= 0 && sales <= 500) commission = 0.05;
                        else if (sales > 500 && sales <= 1000) commission = 0.07;
                        else if (sales > 1000 && sales <= 10000) commission = 0.08;
                        else if (sales > 10000) commission = 0.12;
                        break;
                    case "Varna":
                        if (sales >= 0 && sales <= 500) commission = 0.045;
                        else if (sales > 500 && sales <= 1000) commission = 0.075;
                        else if (sales > 1000 && sales <= 10000) commission = 0.10;
                        else if (sales > 10000) commission = 0.13;
                        break;
                    case "Plovdiv":
                        if (sales >= 0 && sales <= 500) commission = 0.055;
                        else if (sales > 500 && sales <= 1000) commission = 0.08;
                        else if (sales > 1000 && sales <= 10000) commission = 0.12;
                        else if (sales > 10000) commission = 0.145;
                        break;
                }
            }

            if (commission > 0)
            {
                Console.WriteLine("{0:F2}", sales * commission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
