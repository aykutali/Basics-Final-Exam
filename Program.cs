namespace _01._Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fat = int.Parse(Console.ReadLine());
            int protein = int.Parse(Console.ReadLine());
            int carbs = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int percentageWater = int.Parse(Console.ReadLine());

            double gramFat = (totalCalories * (fat / 100.0)) / 9;
            double gramProtein = (totalCalories * (protein / 100.0)) / 4;
            double gramCarbs = (totalCalories * (carbs / 100.0)) / 4;

            double total = gramFat + gramProtein + gramCarbs;
            double caloriesPerGram = totalCalories / total;


            double result = caloriesPerGram - caloriesPerGram * (percentageWater / 100.0);

            Console.WriteLine($"{result:f4}");
        }
    }
}