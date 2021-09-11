using System;
using System.Collections.Generic;

namespace ProjectConsoleMultiplos
{
    public static class Program
    {
        public static void Main()
        {
            IList<int> list = new List<int>();
            int count = 1;

            while (count <= 100)
            {
                if ((count % 3) == 0)
                    list.Add(count);

                count++;
            }

            string values = string.Join(",", list);
            Console.WriteLine("Os números múltiplos de 3 de 1 a 100, são:");
            Console.WriteLine(values);
            Console.ReadLine();
        }
    }
}