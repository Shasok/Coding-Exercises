using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;

namespace Better_PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start;
            int end;

            Console.Write("Type a numbers");

            Console.Write(" \nStarting Numbers: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ending Number: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nThe Prime numbers from {0} to {1} are: ", start, end);

            for (int number = start; number <= end; number++)
            {
                int tall = 0;
                for (int i = 2; i <= number/ 2; i++)
                {
                    if (number % i == 0)
                    {
                        tall++;
                        break;
                    }
                }
                if (tall == 0 && number != 1)
                    Console.Write("| {0} ", number);
            }
            Console.Write("\nPress Any key to continue...");
        }
    }
}