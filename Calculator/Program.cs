using System;
using Serilog;
using CommandLine;

//C:\Users\oli\source\repos\test-repo\Calculator\bin\Debug\net6.0\Calculator.exe

namespace Calculator
{
	public class Program
	{
		public interface ICommand
		{
			void Execute();
		}

		[Verb("add", HelpText = "Adds two numbers together")]
		public class AddCommand : ICommand
		{
			double sum = 0;

			[Option('a', "add", Required = true, HelpText = "Addition")]
			public int Num1 { get; set; }
            public AddCommand(double num1, double num2)
            {
				sum = num1 + num2;
            }

			public void Execute()
			{
				Console.WriteLine($"Your added number is: {sum}");
			}
		}

		[Verb("sub", HelpText = "Subtracts a number from the other")]
		public class SubCommand : ICommand
		{
			double sum = 0;

			[Option('s', "sub", Required = true, HelpText = "Subtraction")]
			public int Num1 { get; set; }
			public SubCommand(double num1, double num2)
			{
				sum = num1 - num2;
			}

			public void Execute()
			{
				Console.WriteLine($"Your subtracted number is: {sum}");
			}
		}

		public static void Main(string[] args)
		{

            Parser.Default.ParseArguments<AddCommand, SubCommand>(args)
			.WithParsed<ICommand>(t => t.Execute());



			/*
			bool endApp = false;
			Console.WriteLine("Console Calculator in C#\r");
			Console.WriteLine("------------------------");

			while (!endApp)
			{
				int num1, num2;
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
				*/

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