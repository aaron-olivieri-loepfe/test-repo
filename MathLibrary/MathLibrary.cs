using System;

namespace Calculator
{
	public class MathLibrary
	{
		public double Addition(double num1, double num2)
		{
			return Math.Round((num1 + num2), 3);
		}

		public double Subtraction(double num1, double num2)
		{
			return Math.Round((num1 - num2), 3);
		}

		public double Multiplication(double num1, double num2)
		{
			return Math.Round((num1 * num2), 3);
		}

		public double Division(double num1, double num2)
		{
			return Math.Round((num1 / num2), 3);
		}

		public double SquareRoot(double num1)
		{
			return Math.Round((Math.Sqrt(num1)), 3);
		}

		public double Perimeter(double num1)
		{
			return Math.Round((2 * Math.PI * num1), 3);
		}
	}
}