using System.Diagnostics.Metrics;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target number: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Enter a number: ");
                int numberGuess = Convert.ToInt32(Console.ReadLine());

                if (numberGuess == targetNumber)
                {
                    counter++;
                }
                else if (numberGuess == 0)
                {
                    Console.WriteLine($"Count of numbers equal to target number: {counter}");
                    break;
                }
            }
        }
    }
}