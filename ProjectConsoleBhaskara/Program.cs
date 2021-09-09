using System;

namespace ProjectConsoleBhaskara
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Calculando formula de bhaskara:");
            Console.WriteLine("\n");

            int a, b, c;

            do
            {
                Console.WriteLine("Informe o valor de A");
            } while (!int.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.WriteLine("Informe o valor de B");
            } while (!int.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.WriteLine("Informe o valor de C");
            } while (!int.TryParse(Console.ReadLine(), out c));

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);

            var result1 = (-(b) + raiz) / (2 * a);
            var result2 = (-(b) - raiz) / (2 * a);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nValor de X1: {Math.Truncate(result1)}");
            Console.WriteLine($"Valor de X2: {Math.Truncate(result2)}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}