using System;
using System.Collections.Generic;

namespace ProjectConsoleMultiplos
{
    public static class Program
    {
        private static void Main()
        {
            IList<int> list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) == 0) list.Add(i);
            }

            var values = string.Join(",", list);
            Console.WriteLine("Os números múltiplos de 3 de 1 a 100, são:");
            Console.WriteLine(values);
            Console.ReadLine();
        }
    }
}