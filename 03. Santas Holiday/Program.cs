namespace _03._Santas_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string score = Console.ReadLine();

            int nights = days - 1;
            double pricePerNight = 0;
            double priceTotal = 0;
            double discount = 0;

            switch (typeRoom)
            {
                case "room for one person":
                    pricePerNight = 18;
                    break;

                case "apartment":
                    pricePerNight = 25;
                    if (nights > 15)
                    {
                        discount = 0.5;
                    }
                    else if (nights > 10)
                    {
                        discount = 0.35;
                    }
                    else
                    {
                        discount = 0.3;
                    }
                    break;

                case "president apartment":
                    pricePerNight = 35;
                    if (nights > 15)
                    {
                        discount = 0.2;
                    }
                    else if (nights > 10)
                    {
                        discount = 0.15;
                    }
                    else
                    {
                        discount = 0.1;
                    }
                    break;

            }
            priceTotal = pricePerNight * nights;
            priceTotal -= priceTotal * discount;

            if (score == "positive")
            {
                priceTotal += priceTotal * 0.25;
            }
            else
            {
                priceTotal -= priceTotal * 0.1;
            }

            Console.WriteLine($"{priceTotal:f2}");
        }
    }
}