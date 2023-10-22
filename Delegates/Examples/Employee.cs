using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Examples
{
	public class Employee
	{
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                if(employee.Experience>=5)
                {
                    Console.WriteLine(employee.Name+" Promoted");
                    employee.Salary = (int)(employee.Salary * 1.5);
                }
            }
        }
    }
}
