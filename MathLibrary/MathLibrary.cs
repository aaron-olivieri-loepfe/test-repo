using System;

namespace Calculator
{
	public class MathLibrary
	{
		public double Addition(double num1, double num2)
		{
			return (num1 + num2);
		}

		public double Subtraction(double num1, double num2)
		{
			return (num1 - num2);
		}

		public double Multiplication(double num1, double num2)
		{
			return (num1 * num2);
		}

		public double Division(double num1, double num2)
		{
			return (num1 / num2);
		}

		public double SquareRoot(double num1)
		{
			return (Math.Sqrt(num1));
		}

		public double Perimeter(double num1)
		{
			return (2 * Math.PI * num1);
		}
	}
}