using ProjectConsoleAluno.Service;
using System;

namespace ProjectConsoleAluno
{
    public static class Program
    {
        private static void Main()
        {
            StudentService service = new();
            int count;
            do
            {
                Console.WriteLine("Informe a quantidade de alunos que deseja inserir as notas:");
            } while (!int.TryParse(Console.ReadLine(), out count));

            for (int i = 1; i <= count; i++)
            {
                service.AddStudent();
            }

            service.StudentsWithAverageThanSeven();
            Console.ReadKey();
        }
    }
}