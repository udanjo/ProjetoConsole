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
                        Console.WriteLine($"Somatória dos valores: {valueA + valueB}");
                        break;

                    case "2":
                        Console.WriteLine($"Subtração dos valores: {valueA - valueB}");
                        break;

                    case "3":
                        var message = valueA == 0
                                 ? "Não é possível dividir por zero"
                                 : $"Divisão dos valores: {valueB / valueA}";
                        Console.WriteLine(message);
                        break;

                    case "4":
                        Console.WriteLine($"Multiplicação dos Valores: {valueA * valueB}");
                        break;

                    case "5":
                        Console.WriteLine(VerifyEvenOrOdd(valueA));
                        Console.WriteLine(VerifyEvenOrOdd(valueB));
                        break;

                    case "6":
                        EnterValues();
                        break;

                    case "9":
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
            Console.WriteLine("Informe um numero para calculos:");
            string valueNumA = Console.ReadLine();
            Console.WriteLine("Informe outro numero:");
            string valueNumB = Console.ReadLine();

            _ = int.TryParse(valueNumA, out valueA);
            _ = int.TryParse(valueNumB, out valueB);
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

        private string VerifyEvenOrOdd(int value)
        {
            return value % 2 == 0 ? $"O numero {value} é Par" : $"O numero {value} é Impar";
        }
    }
}