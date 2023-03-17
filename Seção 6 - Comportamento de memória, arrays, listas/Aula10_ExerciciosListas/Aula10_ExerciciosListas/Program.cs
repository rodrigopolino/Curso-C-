using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula10_ExerciciosListas {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registred? ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>(); //classe instanciada

            for (int i = 0; i < quantidade; i++) {
                Console.WriteLine($"Employee #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            
            Employee emp = list.Find(emp => emp.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}