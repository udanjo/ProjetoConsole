using ProjectConsoleSalario.Service;
using System;

namespace ProjectConsoleSalario
{
    public static class Program
    {
        private static void Main()
        {
            EmployeeService service = new();

            Console.WriteLine("Quantos funcionários você deseja inserir ?");
            _ = int.TryParse(Console.ReadLine(), out int count);

            Console.WriteLine("\n");
            for (int i = 1; i <= count; i++)
            {
                service.AddEmployee();
            }

            service.CalculateLowestSalary();
            service.CalculateHighestSalary();

            Console.WriteLine($"O Maior salário é de {service._highestEmployee.Name} com Valor {service._highestEmployee.Salary}");
            Console.WriteLine("");
            Console.WriteLine($"O Menor salário é de {service._lowestEmployee.Name} com Valor {service._lowestEmployee.Salary}");
            Console.ReadKey();
        }
    }
}