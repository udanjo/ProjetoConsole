using ProjectConsoleAluno.Model;
using System;
using System.Collections.Generic;

namespace ProjectConsoleAluno.Service
{
    public class StudentService
    {
        private readonly IList<Aluno> _students;

        public StudentService()
        {
            _students = new List<Aluno>();
        }

        public void AddStudent()
        {
            Console.WriteLine("Informe o nome do aluno: ");
            var name = Console.ReadLine();

            double grade = 0;
            do
            {
                Console.WriteLine("Informe a nota de 0 a 10: ");
            } while (!double.TryParse(Console.ReadLine(), out grade) && !ValidNote(grade));

            _students.Add(new(name, grade));
        }

        public void StudentsWithAverageThanSeven()
        {
            Console.WriteLine("Alunos com médias superiores a 7: \n");

            foreach (var item in _students)
            {
                if (item.Note > 7)
                {
                    Console.WriteLine($"{item.Name} - Nota: {item.Note}");
                }
            }
        }

        public static bool ValidNote(double grade) => grade >= 0 && grade <= 10;
    }
}