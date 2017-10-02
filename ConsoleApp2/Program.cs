using System;
using PackageB;
using PackageC;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Call through B: {ClassB.Add(1, 2)}");
            
            Console.WriteLine($"Call through B to A: {ClassB.Add2(1, 2)}");

            Console.WriteLine($"Call through C (B): {ClassC.AddB(1, 2)}");

            Console.WriteLine($"Call through C (B): {ClassC.AddB2(1, 2)}");

            Console.ReadLine();
        }
    }
}