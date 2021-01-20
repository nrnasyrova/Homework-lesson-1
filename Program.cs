using System;

namespace firstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double a = 16.8;
            double b = 12.4;

            Console.WriteLine($"Geometric Mean = {Math.Round(Math.Sqrt(a * b), 2)}");
            
            double A = 1.4;
            double B = - 5.5;
            double C = 0.6;

            double lengthAC = A - C;
            double lengthBC = B * (-1) + C;
            double lengths = lengthAC + lengthBC;

            Console.WriteLine($"Length of AC = {Math.Round(lengthAC, 2)}");
            Console.WriteLine($"Length of BC = {Math.Round(lengthBC, 2)}");
            Console.WriteLine($"Sum of lengths of AC and BC = {Math.Round(lengths, 2)}");

            double x1 = - 6.2;
            double y1 = 5.2;
            double x2 = 2.1;
            double y2 = 9.8;

            Console.WriteLine($"Distance = {Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 2)}");

            int number = 41;
            Console.WriteLine($"Reverse number = {((number % 10 ) * 10) + number / 10}");

            int N = 10985;
            Console.WriteLine($"Minutes passed = {N / 60}");

            int K = 202;
            Console.WriteLine($"Day of the week = {202 % 7}");
        }
    }
}
