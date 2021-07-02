using System;

namespace ProjectConsoleValores
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Informe um numero para calculos:");
            var valueNumA = Console.ReadLine();
            Console.WriteLine("Informe outro numero:");
            var valueNumB = Console.ReadLine();

            int.TryParse(valueNumA, out int numbA);
            int.TryParse(valueNumB, out int numbB);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------ESCOLHA UMA OPÇÃO ABAIXO----------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Informar se é Par ou Impar");

            Console.WriteLine();
            Console.WriteLine("Digite sua opção: ");
            string option = Console.ReadLine();

            string message;
            switch (option)
            {
                case "1":
                    message = $"Somatória dos valores: {numbA + numbB}";
                    break;

                case "2":
                    message = $"Subtração dos valores: {numbA - numbB}";
                    break;

                case "3":
                    message = numbA == 0
                             ? "Não é possível dividir por zero"
                             : $"Divisão dos valores: {numbB / numbA}";
                    break;

                case "4":
                    message = $"Multiplicação dos Valores: {numbA * numbB}";
                    break;

                case "5":
                    message = VerifyEvenOrOdd(numbA) + "\n" + VerifyEvenOrOdd(numbB);
                    break;

                default:
                    message = "Opção é Invalida";
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine(message + "\n");
            Console.WriteLine("Pressione qualquer tecla pra continuar...");
            Console.ReadLine();
        }

        private static string VerifyEvenOrOdd(int value)
        {
            return value % 2 == 0 ? $"O numero {value} é Par" : $"O numero {value} é Impar";
        }
    }
}