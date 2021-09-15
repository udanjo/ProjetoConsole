using ProjectConsoleLinq.Services;
using System;

namespace ProjectConsoleLinq
{
    public static class Program
    {
        public static void Main()
        {
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
            service.ListFirstOrder();
            service.ListLastOrder();
            service.ListInsertatFirst();
            service.ListInsertAtLast();
            service.ListRemoveAtFirst();
            service.ListRemoveAtLast();
            service.ListNumberPairs();
            service.ListSearchNumber();
            service.ListToArray();

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}