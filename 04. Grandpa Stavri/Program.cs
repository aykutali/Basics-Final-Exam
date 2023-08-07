namespace _04._Grandpa_Stavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalLitre = 0;
            double totalDegrees = 0;

            for (int i = 0; i < days; i++)
            {
                double currLitre = double.Parse(Console.ReadLine());
                double currDegree = double.Parse(Console.ReadLine());
                totalLitre += currLitre;
                totalDegrees += currLitre * currDegree;
            }
            double degree = totalDegrees / totalLitre;

            Console.WriteLine($"Liter: {totalLitre:f2}");
            Console.WriteLine($"Degrees: {degree:f2}");


            if (degree > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
            else if (degree >= 38)
            {
                Console.WriteLine("Super!");
            }
            else if (degree < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
        }
    }
}