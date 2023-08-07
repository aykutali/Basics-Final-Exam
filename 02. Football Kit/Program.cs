namespace _02._Football_Kit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirts = double.Parse(Console.ReadLine());
            double goalSum = double.Parse(Console.ReadLine());

            double shorts = shirts * 0.75;
            double socks = shorts * 0.2;
            double boots = (shirts + shorts) * 2;

            double total = shirts + shorts + socks + boots;
            total -= total * 0.15;

            if (total >= goalSum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {goalSum - total:F2} lv. more.");
            }
        }
    }
}