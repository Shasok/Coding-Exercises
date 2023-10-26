namespace PrimeNumbers
{
    // Prime number:
    // Input a number -> Range from 0-1000
    // shows all prime numbers from 0 till your input number. 
    // 
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your number between 0 and 1000: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nThese are prime numbers that are below your input:");
            if (num1 <= 100 && num1 >= 97)
            {
                Console.WriteLine(" 97, 89, 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 96 && num1 >= 89)
            {
                Console.WriteLine(" 89, 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 88 && num1 >= 83)
            {
                Console.WriteLine(" 83, 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 82 && num1 >= 79)
            {
                Console.WriteLine(" 79, 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 78 && num1 >= 73)
            {
                Console.WriteLine(" 73, 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 72 && num1 >= 71)
            {
                Console.WriteLine(" 71, 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 68 && num1 >= 67)
            {
                Console.WriteLine(" 67, 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 62 && num1 >= 61)
            {
                Console.WriteLine(" 61, 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 60 && num1 >= 59)
            {
                Console.WriteLine(" 59, 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 54 && num1 >= 53)
            {
                Console.WriteLine(" 53, 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 48 && num1 >= 47)
            {
                Console.WriteLine(" 47, 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 44 && num1 >= 43)
            {
                Console.WriteLine(" 43, 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 42 && num1 >= 41)
            {
                Console.WriteLine(" 41, 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 38 && num1 >= 37)
            {
                Console.WriteLine(" 37, 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 32 && num1 >= 31)
            {
                Console.WriteLine(" 31, 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 30 && num1 >= 29)
            {
                Console.WriteLine(" 29, 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 24 && num1 >= 23)
            {
                Console.WriteLine(" 23, 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 20 && num1 >= 19)
            {
                Console.WriteLine(" 19, 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 18 && num1 >= 17)
            {
                Console.WriteLine(" 17, 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 14 && num1 >= 13)
            {
                Console.WriteLine(" 13, 11, 7, 5, 3, 2");
            }
            if (num1 <= 12 && num1 >= 11)
            {
                Console.WriteLine(" 11, 7, 5, 3, 2");
            }
            if (num1 <= 8 && num1 >= 7)
            {
                Console.WriteLine(" 7, 5, 3, 2");
            }
            if (num1 <= 6 && num1 >= 5)
            {
                Console.WriteLine(" 5, 3, 2");
            }
            if (num1 <= 4 && num1 >= 3)
            {
                Console.WriteLine(" 3, 2");
            }
            if (num1 <= 2 && num1 >= 2)
            {
                Console.WriteLine(" 2");
            }
            if (num1 <= 1)
                Console.WriteLine(" ... Sadly there is no such low prime number");
            if (num1 > 100)
            Console.WriteLine(" Never mind, that was too high of a number");
        }
    }
}
