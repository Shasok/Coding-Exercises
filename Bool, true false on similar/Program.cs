using System;
using System.Diagnostics.Tracing;

namespace Bool__true_false_on_similar
{
    internal class Program

    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int j = 0;
            bool z = false;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (word[i] == word[j])
                {
                    z = true;
                }
                else
                {
                    z = false;
                    break;
                }
                j++;
            }
            if (z)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}