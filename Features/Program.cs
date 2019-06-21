using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {ID = 1, Name = "Scott"},
                new Employee {ID = 2, Name = "Chris"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {ID = 3, Name = "Alex"}
            };

            foreach (var employee in developers.Where(delegate (Employee employee)
                {
                    return employee.Name.StartsWith("S");
                }))
            {
                Console.WriteLine(employee.Name);

            }

        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
