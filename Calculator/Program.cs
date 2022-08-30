using System;
using Serilog;

namespace Calculator
{
	public class Program
	{

		public static void Main()
		{
			bool endApp = false;
			Console.WriteLine("Console Calculator in C#\r");
			Console.WriteLine("------------------------");

			while (!endApp)
			{
				int a, b;
				int sum;
				int sum1;
				int sum2;
				int sum3;

				Console.Write("Enter first number: ");
				a = Convert.ToInt32(Console.ReadLine());

				Console.Write("Enter second number: ");
				b = Convert.ToInt32(Console.ReadLine());
				var calculator = new MathLibrary();
				sum = calculator.Addition(a, b);
				sum1 = calculator.Subtraction(a, b);
				sum2 = calculator.Multiplication(a, b);
				sum3 = calculator.Division(a, b);

				Console.WriteLine("\nResults: \n");
				Console.WriteLine("Addition= " + sum + ", Subtraction= " + sum1);
				Console.WriteLine("Multiplication= " + sum2 + ", Division= " + sum3);
				Console.WriteLine("------------------------\n");

				// Wait for the user to respond before closing.
				Console.Write("Press 'n' and Enter to close the app, or press Enter to continue: ");
				if (Console.ReadLine() == "n") endApp = true;

				Console.WriteLine("\n");

				//Serilog 
				Log.Logger = new LoggerConfiguration()
					.WriteTo.Console()
					.WriteTo.File("log.txt",
						outputTemplate: "{Timestamp:dd-MM-yyyy HH:mm:ss} {Message:lj}{NewLine}{Exception}")
					.CreateLogger();
				Log.Information("This is my first log!");
				Log.CloseAndFlush();
			}
		}
	}
}