using ProjectConsoleBhaskara.services;
using System;

namespace ProjectConsoleBhaskara
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Calculando formula de bhaskara:");
            Console.WriteLine("\n");

            CalculateBhaskaraService bhaskara = new();
            bhaskara.Calculate();
            Console.ReadKey();
        }
    }
}