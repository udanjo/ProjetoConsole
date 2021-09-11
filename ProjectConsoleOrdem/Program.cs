using ProjectConsoleOrdem.Services;
using System;
using System.Collections.Generic;

namespace ProjectConsoleOrdem
{
    public static class Program
    {
        private static void Main()
        {
            IList<decimal> lstNumber = new List<decimal>();
            int count;
            decimal value;

            do
                Console.WriteLine("Qual a quantidade de valores que deseja informar: ");
            while (!int.TryParse(Console.ReadLine(), out count));

            for (int i = 1; i <= count; i++)
            {
                do
                    Console.WriteLine("\nDigite o numero:");
                while (!decimal.TryParse(Console.ReadLine(), out value));

                lstNumber.Add(value);
            }

            CalculateOrderService calculate = new();
            calculate.AscendingOrder(lstNumber);
            calculate.DescendingOrder(lstNumber);
            Console.ReadKey();
        }
    }
}