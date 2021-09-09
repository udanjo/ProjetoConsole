using System;

namespace ProjectConsoleNumerosPares
{
    public class Program
    {
        private const int _countNumber = 4;

        private static void Main()
        {
            int i = 1, totalPairs = 0;
            while (i <= _countNumber)
            {
                int value;
                do
                {
                    Console.WriteLine("Informe um numero:");
                } while (!int.TryParse(Console.ReadLine(), out value));

                totalPairs += value % 2 == 0 ? value : 0;
                i++;
            }

            Console.WriteLine($"\nValor total dos numeros pares é: {totalPairs}");
            Console.ReadKey();
        }
    }
}