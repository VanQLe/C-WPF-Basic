using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPractice
{

    public class EmployeeCompare : IEqualityComparer<Employee>, IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return String.Compare(x.name, y.name);
        }

        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.name, y.name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.name.GetHashCode();
        }
    }

    public class DepartmentCollection: SortedDictionary<string, ISet<Employee>>
    {
        public DepartmentCollection Add(string departmentName, Employee employee)
        {
            if (!ContainsKey(departmentName))
            {
                Add(departmentName, new SortedSet<Employee>(new EmployeeCompare()));
            }

            this[departmentName].Add(employee);

            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var departments = new DepartmentCollection();

            departments.Add("Engineering", new Employee { name = "Van" })
                        .Add("Engineering", new Employee() { name = "Van" })
                        .Add("Engineering", new Employee() { name = "bsdfsdf" })
                        .Add("Engineering", new Employee() { name = "Vdsfsfhfbhvmnnbvan" })
                        .Add("Engineering", new Employee() { name = "Vdvdvxdvan" });


            //departments.Add("Gamer", new SortedSet<Employee>(new EmployeeCompare()));
            //departments["Gamer"].Add(new Employee() { name = "Bob" });
            //departments["Gamer"].Add(new Employee() { name = "Thien" });
            //departments["Gamer"].Add(new Employee() { name = "Alex" });
            //departments["Gamer"].Add(new Employee() { name = "Bob" });

            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine("\t" + employee.name);
                }
            }
            Console.Read();
        }


    }
}
