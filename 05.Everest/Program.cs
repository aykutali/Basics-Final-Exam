namespace _05.Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 5364;
            int goal = 8848;
            int days = 1;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                int metersPerDay = int.Parse(Console.ReadLine());

                if (input == "Yes")
                {
                    days++;
                }

                if (days > 5)
                {

                    break;
                }
                start += metersPerDay;
                if (start >= goal)
                {
                    break;
                }
            }

            if (start >= goal && days <= 5)
            {
                Console.WriteLine($"Goal reached for {days} days!");

            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(start);
            }
        }
    }
}