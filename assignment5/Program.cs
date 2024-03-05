namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a year: ");
                double year = double.Parse(Console.ReadLine());

                if ((year % 4 == 0 || year % 400 == 0) && year % 100 != 0)
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else if (year == 2000)
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
                else if (year < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else if (year == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
            }
        }
    }
}