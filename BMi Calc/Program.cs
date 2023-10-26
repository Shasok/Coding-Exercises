using System;
using System.Security.Cryptography;

class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your weight");
        double Weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You are " + Weight + "Kg");
        Console.WriteLine("Enter your height");
        double Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("you are " + Height + " in CM");

        double BMI = (Weight) / ((Height * Height)/10000);
        Console.Write("\nYour BMI index is {0}", BMI);
        Console.ReadLine();
        if (BMI < 18.5)
        {
            Console.WriteLine("You are underweight");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("You have normal weight");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("You are slightly overweight");
        }
        else if (BMI >= 30 && BMI < 35)
        {
            Console.WriteLine("You are overweight");
        }
        else if (BMI >= 35 && BMI < 40)
        {
            Console.WriteLine("You are obese");
        }
        else if (BMI > 40)
        {
            Console.WriteLine("You are severely obese");
        }
        Console.ReadLine();
    }
}