using ProjectConsoleSalario.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectConsoleSalario.Service
{
    public class EmployeeService
    {
        public Employee _lowestEmployee;
        public Employee _highestEmployee;
        private readonly IList<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee()
        {
            Console.WriteLine("Informe o nome do funcionário: ");
            var name = Console.ReadLine();

            Console.WriteLine("Informe o salário: ");
            _ = decimal.TryParse(Console.ReadLine(), out decimal salary);

            Console.WriteLine("");

            _employees.Add(new(name, salary));
        }

        public void CalculateLowestSalary()
        {
            decimal lowest = _employees.FirstOrDefault().Salary;
            string name = _employees.FirstOrDefault().Name;
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Salary < lowest)
                {
                    lowest = _employees[i].Salary;
                    name = _employees[i].Name;
                }
            }

            _lowestEmployee = new(name, lowest);
        }

        public void CalculateHighestSalary()
        {
            decimal highest = _employees.FirstOrDefault().Salary;
            string name = _employees.FirstOrDefault().Name;
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Salary > highest)
                {
                    highest = _employees[i].Salary;
                    name = _employees[i].Name;
                }
            }

            _highestEmployee = new(name, highest);
        }
    }
}