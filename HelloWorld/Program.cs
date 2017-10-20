using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine("What is your first name");
			string name = Console.ReadLine();
			Console.WriteLine("First name provided: " + name);
		}
	}
}
