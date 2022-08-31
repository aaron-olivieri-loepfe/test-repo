using System;
using Serilog;
using CommandLine;

//C:\Users\oli\source\repos\test-repo\Calculator\bin\Debug\net6.0\Calculator.exe

namespace Calculator
{
	public class Program
	{
		public static void Main()
		{
			bool endApp = false;

			while (!endApp)
			{
				var args = Console.ReadLine().Split();
				// (1) default options
				var result = Parser.Default.ParseArguments<Options>(args);
				// or (2) build and configure instance
				//var parser = new Parser(with => with.HelpWriter=Console.Out);	

				result.WithParsed(options =>
				{
					string a = "add";
					string s = "sub";
					string d = "div";
					string m = "mul";
					string x = "end";

					if (!options.Operation.Contains(x))
					{
						if (options.Operation.Contains(a))
						{
							double sum = options.Num1 + options.Num2;
							Console.WriteLine($"Addition: {options.Num1} + {options.Num2} = {sum}\n");

						}

						if (options.Operation.Contains(s))
						{
							double sum = options.Num1 - options.Num2;
							Console.WriteLine($"Subtraction: {options.Num1} - {options.Num2} = {sum}\n");
						}

						if (options.Operation.Contains(d))
						{
							double sum = options.Num1 / options.Num2;
							Console.WriteLine($"Division: {options.Num1} / {options.Num2} = {sum}\n");
						}

						if (options.Operation.Contains(m))
						{
							double sum = options.Num1 * options.Num2;
							Console.WriteLine($"Multiplication: {options.Num1} * {options.Num2} = {sum}\n");
						}
					}
					else
					{
						Console.WriteLine("The program will end now.");
						System.Environment.Exit(333);
					}
				}
				).WithNotParsed(errs => Console.WriteLine("Failed with errors:\n{0}",
					String.Join("\n", errs)));

			//Serilog 
			Log.Logger = new LoggerConfiguration()
						.WriteTo.Console()
						.WriteTo.File("log.txt",
							outputTemplate: "This log was created on {Timestamp:dd-MM-yyyy, HH:mm:ss} {Message:lj}{NewLine}{Exception}")
						.CreateLogger();
			Log.Information("");
			Log.CloseAndFlush();
			}
		}




		// Befehle nicht als String, sondern als befehel auswerten und validieren (z.b. "du willst Addition")
		// nachher evtl auch noch Sqr Root einfügen, Kreisdurchmesser o.ä.
		// Copyright und ähnliche generic felder vom CommandLineParser entfernen / deaktivieren
		class Options
		{
			[Value(0, Max = 1)]
			public IEnumerable<string> Operation
			{
				get;
				set;
			}

			[Value(1)]
			public double Num1
			{
				get;
				set;
			}

			[Value(2)]
			public double Num2
			{
				get;
				set;
			}

		}
	}
}