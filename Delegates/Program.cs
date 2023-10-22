using Delegates.Examples;

namespace Delegates
{
	public delegate void PromoteDelegate(List<Employee> Employees);
	public delegate void HelloDelegate(string message);
	public class Program
	{
		static void Main(string[] args)
		{
			HelloDelegate del = new HelloDelegate(Hello);
			del("Hello, World");

			List<Employee> Employees = new List<Employee>();
			Employees.Add(new Employee { ID=1,Experience=3,Salary=10000,Name="Chaitanya"});
			Employees.Add(new Employee { ID=2,Experience=4,Salary=10000,Name="Kanhaiya"});
			Employees.Add(new Employee { ID=3,Experience=5,Salary=10000,Name="Charu"});
			Employees.Add(new Employee { ID=4,Experience=6,Salary=10000,Name="Rishu"});
			PromoteDelegate pd = new PromoteDelegate(Employee.PromoteEmployee);
			pd(Employees);
		}
		public static void Hello(string message)
		{
			Console.WriteLine(message);
		}
	}
}