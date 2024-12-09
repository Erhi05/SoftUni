namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int night = int.Parse(Console.ReadLine()) - 1;
            string type = Console.ReadLine();
            string grade = Console.ReadLine();

            double price = 0;

            switch (type)
            {
                case "room for one person":
                    price = night * 18;

                    if (grade == "positive")
                    {
                        price *= 1.25;
                    }
                    else
                    {
                        price *= 0.9;
                    }
                    break;
                case "apartment":
                    price = night * 25;
                    if (night < 10)
                    {
                        price *= 0.7;
                    }
                    else if (night >= 10 && night < 15)
                    {
                        price *= 0.65;
                    }
                    else
                    {
                        price *= 0.5;
                    }

                    if (grade == "positive")
                    {
                        price *= 1.25;
                    }
                    else
                    {
                        price *= 0.9;
                    }
                    break;
                case "president apartment":
                    price = night * 35;
                    if (night < 10)
                    {
                        price *= 0.9;
                    }
                    else if (night >= 10 && night < 15)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price *= 0.8;
                    }

                    if (grade == "positive")
                    {
                        price *= 1.25;
                    }
                    else
                    {
                        price *= 0.9;
                    }
                    break;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
