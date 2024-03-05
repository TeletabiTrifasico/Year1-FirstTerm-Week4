using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            int number = 1;
            int amount = 0;
            double sum = 0;

            while (number != 0)
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();
                number = Convert.ToInt32(input);
                

                if (number > 0)
                {
                    sum += number;
                    amount++;
                }
                else if (number == 0)
                {
                    if (sum == 0)
                    {
                        Console.WriteLine($"Average of all positive numbers is: {sum:0.00}");
                    }
                    else
                    {
                        sum = sum / amount;
                        Console.WriteLine($"Average of all positive numbers is: {sum:0.00}");
                        break;
                    }
                }
            }
        }
    }
}