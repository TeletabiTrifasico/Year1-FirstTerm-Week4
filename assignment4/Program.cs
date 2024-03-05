namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int one = 0;
            int two = 1;

            for (int i = 0; i < 20; i++)
            {
                one = two;
                two = sum;
                sum = one + two;
                Console.Write($"{sum}, ");
            }
        }
    }
}