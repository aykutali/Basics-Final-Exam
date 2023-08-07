namespace _06._Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            bool is5 = false;

            for (int a = k; a <= 8; a++)
            {
                for (int b = 9; b >= l; b--)
                {
                    for (int c = m; c <= 8; c++)
                    {
                        for (int d = 9; d >= n; d--)
                        {
                            if (a % 2 == 0 && c % 2 == 0)
                            {
                                if (b % 2 != 0 && d % 2 != 0)
                                {
                                    if (a == c && b == d)
                                    {
                                        Console.WriteLine("Cannot change the same player.");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{a}{b} - {c}{d}");
                                        count++;
                                        if (count >= 6)
                                        {
                                            is5 = true;
                                        }
                                    }
                                }
                            }

                            if (is5)
                            {
                                break;
                            }
                        }

                        if (is5)
                        {
                            break;
                        }
                    }

                    if (is5)
                    {
                        break;
                    }
                }

                if (is5)
                {
                    break;
                }
            }
        }
    }
}