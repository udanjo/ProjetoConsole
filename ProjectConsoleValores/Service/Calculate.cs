using System;

namespace ProjectConsoleValores.Service
{
    public class Calculate
    {
        private int valueA, valueB;

        public void Calcular()
        {
            EnterValues();
            string option;

            do
            {
                option = PrintMenu();

                Console.WriteLine("\n");

                switch (option)
                {
                    case "1":
                        PrintMessage($"Somatória dos valores: {valueA + valueB}");
                        break;

                    case "2":
                        PrintMessage($"Subtração dos valores: {valueA - valueB}");
                        break;

                    case "3":
                        var message = valueA == 0
                                 ? "Não é possível dividir por zero"
                                 : $"Divisão dos valores: {valueB / valueA}";
                        PrintMessage(message);
                        break;

                    case "4":
                        PrintMessage($"Multiplicação dos Valores: {valueA * valueB}");
                        break;

                    case "5":
                        PrintMessage(VerifyEvenOrOdd(valueA));
                        PrintMessage(VerifyEvenOrOdd(valueB));
                        break;

                    case "6":
                        EnterValues();
                        break;

                    case "9":
                        Console.WriteLine("Pressione enter pra finalizar...");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Opção é Invalida");
                        break;
                }
                Console.WriteLine("\n");
            } while (option != "9");
        }

        private void EnterValues()
        {
            do
            {
                Console.WriteLine("Informe um numero para calculos");
            } while (!int.TryParse(Console.ReadLine(), out valueA));

            do
            {
                Console.WriteLine("Informe outro numero:");
            } while (!int.TryParse(Console.ReadLine(), out valueB));
        }

        public string PrintMenu()
        {
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
            Console.WriteLine("6 - Informar novos números");
            Console.WriteLine("9 - Sair");

            Console.WriteLine();
            Console.WriteLine("Digite sua opção: ");
            return Console.ReadLine();
        }

        public void PrintMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"--> {message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private string VerifyEvenOrOdd(int value)
        {
            return value % 2 == 0 ? $"O numero {value} é Par" : $"O numero {value} é Impar";
        }
    }
}