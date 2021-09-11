using ProjectConsoleSalario.Service;
using System;

namespace ProjectConsoleSalario
{
    public static class Program
    {
        private static void Main()
        {
            EmployeeService service = new();

            int count;
            do
            {
                Console.WriteLine("Quantos funcionários você deseja inserir ?");
            } while (!int.TryParse(Console.ReadLine(), out count));

            Console.WriteLine("\n");
            for (int i = 1; i <= count; i++)
            {
                service.AddEmployee();
            }

            service.CalculateLowestSalary();
            service.CalculateHighestSalary();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nO Maior salário é do funcionário: {service._highestEmployee.Name} com Valor {service._highestEmployee.Salary}");
            Console.WriteLine($"\nO Menor salário é do funcionário: {service._lowestEmployee.Name} com Valor {service._lowestEmployee.Salary}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}