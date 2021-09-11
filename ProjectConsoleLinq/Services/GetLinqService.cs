using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleLinq.Services
{
    public class GetLinqService
    {
        private IList<int> lstNumber = null;

        public GetLinqService()
        {
            lstNumber = new List<int>();
        }

        public void GetListNumber(int count)
        {
            int value;
            for (int i = 1; i <= count; i++)
            {
                do
                    Console.WriteLine("\nDigite o numero:");
                while (!int.TryParse(Console.ReadLine(), out value));

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
            lstNumber.Insert(0, GetNumber());
            Console.WriteLine($"Valores com o número inserido no inicio = {string.Join(" - ", lstNumber)}");
        }

        public void ListInsertAtLast()
        {
            lstNumber.Add(GetNumber());
            Console.WriteLine($"Valores com o número inserido no final  = {string.Join(" - ", lstNumber)}");
        }

        public void ListRemoveAtFirst()
        {
            lstNumber.RemoveAt(0);
            Console.WriteLine($"Valores com o primeiro removido = {string.Join(" - ", lstNumber)}");
        }

        public void ListRemoveAtLast()
        {
            lstNumber.RemoveAt(lstNumber.Count);
            Console.WriteLine($"Valores com o último removido  = {string.Join(" - ", lstNumber)}");
        }

        public void ListNumberPairs()
        {
            var newlist = lstNumber.Where(w => ((w % 2) == 0)).ToList();
            Console.WriteLine($"Valores com apenas os números pares  = {string.Join(" - ", newlist)}");
        }

        //private  string ListNumber(this IList<int> ls) => ls[0].ToString() + " - " + ls[ls.Count - 1].ToString();

        public void ListToArray() => 
            Console.WriteLine($"Transforme todos os números da lista em um Array  = {string.Join(" - ", lstNumber.ToArray())}");


        private int GetNumber()
        {
            int value;
            do
                Console.WriteLine("\nDigite o numero para inserir:");
            while (!int.TryParse(Console.ReadLine(), out value));

            return value;
        }
    }
}