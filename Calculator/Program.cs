using System;
namespace Calculator
{
	public class Program
	{

		public static void Main()
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
			var calculator = new Operation();
			sum = calculator.Addition(a, b);
			sum1 = calculator.Subtraction(a, b);
			sum2 = calculator.Multiplication(a, b);
			sum3 = calculator.Division(a, b);




			Console.WriteLine("Addition= " + sum + ", Subtraction= " + sum1);
		}
	}
}