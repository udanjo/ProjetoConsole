using ProjectConsoleLinq.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleLinq
{
    public static class Program
    {
        public static void Main()
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

            GetLinqService service = new();

            int count;
            do
                Console.WriteLine("Qual a quantidade de valores que deseja informar: ");
            while (!int.TryParse(Console.ReadLine(), out count));

            service.GetListNumber(count);

            Console.ForegroundColor = ConsoleColor.Green;

            service.ListComplete();
            service.ListAscOrder();
            service.ListDescOrder();

            //Console.WriteLine($"Valores com ordenação crescente = {lstNumber.ListAscOrder()}");
            //Console.WriteLine($"Valores com ordenação decrescente = {lstNumber.ListDescOrder()}");
            //Console.WriteLine($"Valores com apenas o primeiro número = {lstNumber.ListFirstOrder()}");
            //Console.WriteLine($"Valores com apenas o último número = {lstNumber.ListLastOrder()}");
            //Console.WriteLine($"Valores com o número 99 inserido no inicio = {lstNumber.ListInsertAtFirst()}");
            //Console.WriteLine($"Valores com o número 98 inserido no final  = {lstNumber.ListInsertAtLast()}");
            //Console.WriteLine($"Valores com o primeiro removido = {lstNumber.ListRemoveAtFirst()}");
            //Console.WriteLine($"Valores com o último removido  = {lstNumber.ListRemoveAtLast()}");
            //Console.WriteLine($"Valores com apenas os números pares  = {lstNumber.ListNumberPairs()}");
            //Console.WriteLine($"Valores apenas o número informado  = {lstNumber.ListNumber()}");
            //Console.WriteLine($"Transforme todos os números da lista em um Array  = {lstNumber.ListNumber()}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }


    }
}