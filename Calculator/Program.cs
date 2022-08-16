using System;
namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                string numInput1 = "";
                string numInput2 = "";
 
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();
            }
            return;
        }
    }
}