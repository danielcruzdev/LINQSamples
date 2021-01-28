using System;
using System.Collections.Generic;
using System.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> duplicate = x => x * x;
            Func<int, int, int> func2 = (x, y) => x + y;

            Action<string> write = x => Console.WriteLine(x);

            write("TESTE");
            Console.WriteLine(duplicate(10));
            Console.WriteLine(func2(10, 2));

            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Daniel"},
                new Employee {Id = 2, Name = "Karina"},
                new Employee {Id = 3, Name = "Karin"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            foreach (var employee in developers.Where(e => e.Name.Length == 5).OrderBy(x => x.Name))
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
