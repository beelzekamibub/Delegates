namespace Delegates
{
	public delegate void HelloDelegate(string message);
	public class Program
	{
		static void Main(string[] args)
		{
			HelloDelegate del = new HelloDelegate(Hello);
			del("Hello, World");
		}
		public static void Hello(string message)
		{
			Console.WriteLine(message);
		}
	}
}