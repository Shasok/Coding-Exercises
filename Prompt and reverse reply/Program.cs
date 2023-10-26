using System;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string gecko = Console.ReadLine();
        for (int i = gecko.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(gecko[i]);
        }
    }
}