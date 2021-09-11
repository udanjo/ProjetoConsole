using ProjectConsoleAluno.Model;
using System;
using System.Collections.Generic;

namespace ProjectConsoleAluno.Service
{
    public class StudentService
    {
        private readonly IList<Aluno> _Alunos;

        public StudentService()
        {
            _Alunos = new List<Aluno>();
        }

        public void AddStudent()
        {
            Console.WriteLine("\nInforme o nome do aluno: ");
            var name = Console.ReadLine();

            double grade = 0;
            do
            {
                Console.WriteLine($"Informe a nota do(a) {name} - (De 0 a 10): ");
            } while (!double.TryParse(Console.ReadLine(), out grade) || !ValidNote(grade));

            _Alunos.Add(new(name, grade));
        }

        public void StudentsWithAverageThanSeven()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAlunos com médias superiores a 7: \n");

            foreach (var item in _Alunos)
            {
                if (item.Note > 7)
                {
                    Console.WriteLine($"{item.Name} - Nota: {item.Note}");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public  bool ValidNote(double grade) => grade >= 0 && grade <= 10;
    }
}