using System;
using System.Text;
using System.Threading.Tasks;

namespace Calc_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                double res;
                Console.Write("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to do more(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
    }
}
