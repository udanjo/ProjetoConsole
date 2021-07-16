using System;

namespace ProjectConsoleAluno
{
    public static class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Informe a quantidade de alunos que deseja inserir as notas:");
            _ = int.TryParse(Console.ReadLine(), out int count);


        }
    }
}
