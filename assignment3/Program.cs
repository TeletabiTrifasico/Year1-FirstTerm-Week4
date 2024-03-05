namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fifthInput = 0;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                fifthInput++;
                if (fifthInput == 5)
                {
                    sum += number;
                    fifthInput = 0;
                }
                else if (number == 0)
                {
                    Console.WriteLine($"Sum of 5th, 10th, 15th, ... number is: {sum}");
                    break;
                }
            }
        }
    }
}