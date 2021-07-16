using ProjectConsoleAluno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsoleAluno.Service
{
    public class StudentService
    {
        private readonly IList<Student> _students;

        public StudentService()
        {
            _students = new List<Student>();
        }

        public void AddStudent()
        {
            Console.WriteLine("Informe o nome do aluno: ");
            var name = Console.ReadLine();
            int grade;
            do
            {
                Console.WriteLine("Informe a nota do aluno: ");
            } while (!int.TryParse(Console.ReadLine(), out grade));

            _students.Add(new(name, grade));
        }


    }
}
