using System;

namespace ProjectConsoleSalario
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            string nome = "", nomeMaior = "", nomeMenor = "";
            decimal salario = 0, salarioMaior = 0, salarioMenor = 0;
            do
            {
                Console.WriteLine("Informe o nome:");
                nome = Console.ReadLine();

                if(!string.Equals(nome, "Parar", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("Informe o salário:");
                    var result = Console.ReadLine();
                    salario = decimal.Parse(result);

                    if (salario > salarioMaior)
                    {
                        nomeMaior = nome;
                        salarioMaior = salario;
                    }

                    if(salario < salarioMenor)
                    {
                        nomeMenor = nome;
                        salarioMenor = salario;
                    }
                }

            } while (!string.Equals(nome, "Parar", StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine($"O Maior salário é de {nomeMaior} com Valor {salarioMaior}");
            Console.WriteLine("");
            Console.WriteLine($"O Menor salário é de {nomeMenor} com Valor {salarioMenor}");
            Console.ReadKey();
        }
    }
}
