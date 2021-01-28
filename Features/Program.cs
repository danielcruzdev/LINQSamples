using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Daniel"},
                new Employee {Id = 2, Name = "Karina"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            foreach (var employee in developers.Where(e => e.Name.StartsWith("D")))
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
