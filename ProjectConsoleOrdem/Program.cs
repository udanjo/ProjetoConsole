using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleOrdem
{
    public static class Program
    {
        private static void Main()
        {
            IList<int> lstNumber = new List<int>();
            int count, value;

            do
                Console.WriteLine("Qual a quantidade de valores que deseja informar: ");
            while (!int.TryParse(Console.ReadLine(), out count));

            for (int i = 1; i <= count; i++)
            {
                do
                    Console.WriteLine("\nDigite o numero:");
                while (!int.TryParse(Console.ReadLine(), out value));

                lstNumber.Add(value);
            }

            var ascOrder = lstNumber.OrderBy(x => x).ToList();
            var descOrder = lstNumber.OrderByDescending(x => x).ToList();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nValor com ordenação crescente = {string.Join(",", ascOrder)}");
            Console.WriteLine($"Valor com ordenação decrescente = {string.Join(",", descOrder)}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}