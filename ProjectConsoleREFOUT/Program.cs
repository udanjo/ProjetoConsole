using System;

namespace ProjectConsoleREFOUT
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Qual é a diferença entre REF e OUT?");

            Console.WriteLine();
            Console.WriteLine("REF: Usando a palavra-chave 'ref' é como uma referencia, logo quando a variavel é passada no método, qualquer alteração nela irá mudar a variavel chamada");
            Console.WriteLine();
            Console.WriteLine("OUT: Usando a palavara-chave 'out' é para saída de valor, logo a variavél não precisa ser inicializada ou qualquer valor nela");

            string animalRef = "Sapo"; //Precisa ser Inicializado
            string animalOut; // opcional

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------Por REF------");
            Console.WriteLine($"Variavel instanciada com {animalRef}");
            AlterRef(ref animalRef);
            Console.WriteLine($"Retorno do Animal é {animalRef}");

            Console.WriteLine("\n");

            Console.WriteLine("-------Por OUT------");
            Console.WriteLine("Variavel vazia");
            AlterOut(out animalOut);
            Console.WriteLine($"Retorno do Animal é {animalOut}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }

        public static void AlterRef(ref string pAnimal)
        {
            pAnimal = "Urso";
        }

        public static void AlterOut(out string pAnimal)
        {
            pAnimal = "Panda";
        }
    }
}