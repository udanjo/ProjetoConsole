using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleOrdem.Services
{
    public class CalculateOrderService
    {
        public void AscendingOrder(IList<decimal> ls)
        {
            var ascOrder = ls.OrderBy(x => x).ToList();
            SetMessage($"\nValor com ordenação crescente = {string.Join(" - ", ascOrder)}");
        }

        public void DescendingOrder(IList<decimal> ls)
        {
            var descOrder = ls.OrderByDescending(x => x).ToList();
            SetMessage($"Valor com ordenação decrescente = {string.Join(" - ", descOrder)}");
        }

        private void SetMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}