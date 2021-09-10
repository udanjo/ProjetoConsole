using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleLinq
{
    public static class Program
    {
        static void Main()
        {
            //Crie uma lista que receba inteiros. -- OK
            //Imprimir todos os números da lista. -- OK
            //Imprimir todos os números da lista na ordem crescente. -- OK
            //Imprimir todos os números da lista na ordem decrescente. -- OK
            //Imprima apenas o primeiro número da lista. -- OK
            //Imprima apenas o ultimo número da lista. -- OK
            //Insira um número no início da lista.
            //Insira um número no final da lista.
            //Remova o primeiro número.
            //Remova o último número.
            //Retorne apenas os números pares.
            //Retorne apenas o número informado.
            //Transforme todos os números da lista em um Array.


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
            var firstOrder = lstNumber.FirstOrDefault();
            var lastOrder = lstNumber.LastOrDefault();
            lstNumber.Add(99);
            var insertAtStart = lstNumber;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nValor são = {string.Join(" - ", lstNumber)}");
            Console.WriteLine($"Valor com ordenação crescente = {string.Join(" - ", ascOrder)}");
            Console.WriteLine($"Valor com ordenação decrescente = {string.Join(" - ", descOrder)}");
            Console.WriteLine($"Valor com apenas o primeiro número = {string.Join(" - ", firstOrder)}");
            Console.WriteLine($"Valor com apenas o ultimo número = {string.Join(" - ", lastOrder)}");
            Console.WriteLine($"Valor com o Numero 99 inserido = {string.Join(" - ", lstNumber)}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        //private void Calc()
        //{

        //}
    }
}
