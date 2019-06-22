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
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Action<int> write = x => Console.WriteLine(x);

            write(square((add(3,5))));

            var developers = new Employee[]
            {
                new Employee {ID = 1, Name = "Scott"},
                new Employee {ID = 2, Name = "Chris"}
            };

            var sales = new List<Employee>()
            {
                new Employee {ID = 3, Name = "Alex"}
            };

            var query = developers.Where(e => e.Name.Length == 5)
                                  .OrderBy(e => e.Name)
                                  .Select (e => e);

            var query2 = from developer in developers
                         where developer.Name.Length == 5
                         orderby developer.Name
                         select developer;

            foreach (var employee in query2)
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
