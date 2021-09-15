using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleLinq.Services
{
    public class GetLinqService
    {
        private readonly IList<int> lstNumber = null;

        public GetLinqService()
        {
            lstNumber = new List<int>();
        }

        public void GetListNumber(int count)
        {
            int value;
            for (int i = 1; i <= count; i++)
            {
                value = GetNumber();
                lstNumber.Add(value);
            }
        }

        public void ListComplete() => Console.WriteLine($"\nValores são = {string.Join(" - ", lstNumber)}");

        public void ListAscOrder() => Console.WriteLine($"Valores com ordenação crescente = {string.Join(" - ", lstNumber.OrderBy(x => x).ToList())}");

        public void ListDescOrder() => Console.WriteLine($"Valores com ordenação decrescente = {string.Join(" - ", lstNumber.OrderByDescending(x => x).ToList())}");

        public void ListFirstOrder() => Console.WriteLine($"Valores com apenas o primeiro número = {string.Join(" - ", lstNumber.FirstOrDefault())}");

        public void ListLastOrder() => Console.WriteLine($"Valores com apenas o último número = {string.Join(" - ", lstNumber.LastOrDefault())}");

        public void ListInsertatFirst()
        {
            var number = GetNumber("Informe um numero para inserir no inicio");
            lstNumber.Insert(0, number);
            Console.WriteLine($"Valores com o número inserido no inicio = {string.Join(" - ", lstNumber)}");
        }

        public void ListInsertAtLast()
        {
            var number = GetNumber("Informe um numero para inserir no inicio");
            lstNumber.Add(number);
            Console.WriteLine($"Valores com o número inserido no final  = {string.Join(" - ", lstNumber)}");
        }

        public void ListRemoveAtFirst()
        {
            lstNumber.RemoveAt(0);
            Console.WriteLine($"Valores com o primeiro removido = {string.Join(" - ", lstNumber)}");
        }

        public void ListRemoveAtLast()
        {
            lstNumber.RemoveAt(lstNumber.Count - 1);
            Console.WriteLine($"Valores com o último removido  = {string.Join(" - ", lstNumber)}");
        }

        public void ListNumberPairs()
        {
            var newlist = lstNumber.Where(w => ((w % 2) == 0)).ToList();
            Console.WriteLine($"Valores com apenas os números pares  = {string.Join(" - ", newlist)}");
        }

        public void ListSearchNumber()
        {
            int value = GetNumber("Informe um numero para consultar: ");
            var list = lstNumber.Where(x => x == value).ToList();
            if (list.Count > 0)
                Console.WriteLine($"Valores consultado encontrado é = {string.Join(" - ", list)}");
            else
                Console.WriteLine("Não foi encontrado esse valor na list");
        }

        public void ListToArray() =>
            Console.WriteLine($"Transforme todos os números da lista em um Array  = {string.Join(" - ", lstNumber.ToArray())}");

        private int GetNumber(string message = "Digite o numero para inserir:")
        {
            int value;
            Console.ForegroundColor = ConsoleColor.White;
            do
                Console.WriteLine("\n" + message);
            while (!int.TryParse(Console.ReadLine(), out value));

            Console.ForegroundColor = ConsoleColor.Green;
            return value;
        }
    }
}