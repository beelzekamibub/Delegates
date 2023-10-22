using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Examples
{
	public delegate bool PromotioCriteria(Employee employee);
	public class BetterExample:Employee
	{
		public static void BetterPromotion(List<Employee> employees,PromotioCriteria pc)
		{
			foreach (Employee employee in employees)
			{
				if (pc(employee))
				{
					Console.WriteLine(employee.Name + " Promoted");
					employee.Salary = (int)(employee.Salary * 1.5);
				}
			}
		}
	}
}
