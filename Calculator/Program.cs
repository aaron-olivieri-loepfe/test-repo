using Calculator;
using CommandLine;
using System.Reflection;
using Serilog;

namespace CommandCalculator
{

    public class CommandCalculator
    {
        public static void Main()
        {
            bool endApp = false;

            while (!endApp)
            {
                var line = new String('-', 40);

                var args = Console.ReadLine().Split();
                Start(args);

                Console.WriteLine("\nDo you want to continue? (Y/N)");
                char choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");

                if (choice == 'N' || choice == 'n')
                {
                    endApp = true;
                }

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

        public static void Start(string[] args)
        {
            Console.WriteLine($"Args: {string.Join(' ', args.Select(x => $"\"{x}\""))}");
            var types = LoadVerbs();
            Parser.Default.ParseArguments(args, types)
                .WithParsed(Run)
                .WithNotParsed(HandleErrors);
        }
        //load all Verb types using Reflection
        static Type[] LoadVerbs()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetCustomAttribute<VerbAttribute>() != null).ToArray();
        }

        public static void Run(object obj)
        {
            switch (obj)
            {
                case AdditionOptions a:
                    RunAddition(a);
                    break;
                case SubtractionOptions b:
                    RunSubtraction(b);
                    break;
                case MultiplicationOptions c:
                    RunMultiplication(c);
                    break;
                case DivisionOptions c:
                    RunDivision(c);
                    break;
                case SquareRootOptions d:
                    RunSquareRoot(d);
                    break;
                case PerimeterOptions e:
                    RunPerimeter(e);
                    break;

            }
            //process AdditionOptions
            void RunAddition(AdditionOptions args)
            {
                Console.WriteLine("Processing Addition Calculation");
                MathLibrary mathLibrary = new MathLibrary();
                double sum = mathLibrary.Addition(args.num1,args.num2);
                Console.WriteLine(args.num1 + " + " + args.num2 + " = " + sum);

            }
            //process SubtractionOptions
            void RunSubtraction(SubtractionOptions args)
            {
                Console.WriteLine("Processing Subtraction Calculation");
                MathLibrary mathLibrary = new MathLibrary();
                double sum = mathLibrary.Subtraction(args.num1, args.num2);
                Console.WriteLine(args.num1 + " - " + args.num2 + " = " + sum);

            }
            //process MultiplicationOptions
            void RunMultiplication(MultiplicationOptions args)
            {
                Console.WriteLine("Processing Multiplication Calculation");
                MathLibrary mathLibrary = new MathLibrary();
                double sum = mathLibrary.Multiplication(args.num1, args.num2);
                Console.WriteLine(args.num1 + " * " + args.num2 + " = " + sum);

            }
            //process DivisionOptions
            void RunDivision(DivisionOptions args)
            {
                Console.WriteLine("Processing Division Calculation");
                MathLibrary mathLibrary = new MathLibrary();
                double sum = mathLibrary.Division(args.num1, args.num2);
                Console.WriteLine(args.num1 + " / " + args.num2 + " = " + sum);

            }
            //process SquareRootOptions
            void RunSquareRoot(SquareRootOptions args)
            {
                Console.WriteLine("Processing SquareRoot Calculation");
                MathLibrary mathLibrary = new MathLibrary();
                double sum = mathLibrary.SquareRoot(args.num1);
                Console.WriteLine("Square Root of " + args.num1 + " is " + sum);

            }
            //process PerimeterOptions
            void RunPerimeter(PerimeterOptions args)
            {
                Console.WriteLine("Processing Perimeter Calculation");
                MathLibrary mathLibrary = new MathLibrary();
                double sum = mathLibrary.Perimeter(args.num1);
                Console.WriteLine("The Perimeter of radius " + args.num1 + " is " + sum);

            }
        }
        private static void HandleErrors(IEnumerable<Error> obj)
        {
            Console.WriteLine("Your input is invalid.");
        }
    }


    [Verb("add", HelpText = "Adds two numbers together and shows sum.")]
    internal class AdditionOptions
    {

        [Value(1)]
        public double num1 { get; set; }

        [Value(2)]
        public double num2 { get; set; }

    }

    [Verb("sub", HelpText = "Subtracts two numbers together and shows sum.")]
    internal class SubtractionOptions
    {

        [Value(1)]
        public double num1 { get; set; }

        [Value(2)]
        public double num2 { get; set; }

    }

    [Verb("mul", HelpText = "Multiplicates two numbers together and shows sum.")]
    internal class MultiplicationOptions
    {

        [Value(1)]
        public double num1 { get; set; }

        [Value(2)]
        public double num2 { get; set; }

    }

    [Verb("div", HelpText = "Divides two numbers together and shows sum.")]
    internal class DivisionOptions
    {

        [Value(1)]
        public double num1 { get; set; }

        [Value(2)]
        public double num2 { get; set; }

    }

    [Verb("sqrt", HelpText = "Calculates the Square Root of the entered number.")]
    internal class SquareRootOptions
    {

        [Value(1)]
        public double num1 { get; set; }

    }

    [Verb("peri", HelpText = "Calculates the Perimeter of the entered radius.")]
    internal class PerimeterOptions
    {

        [Value(1)]
        public double num1 { get; set; }

    }

    class HelpConstant
    {
        public const string Clone_local = "When the repository to clone from is on a local machine, this flag bypasses the normal \"Git aware\" transport mechanism and clones the repository by making a copy of HEAD and everything under objects and refs directories.";
        public const string Clone_quiet = "Operate quietly. Progress is not reported to the standard error stream.";
        public const string Clone_repository = "The (possibly remote) repository to clone from. See the GIT URLS section below for more information on specifying repositories.";

        //commit
        public const string Commit_message = "Use the given <msg> as the commit message. If multiple -m options are given, their values are concatenated as separate paragraphs.";
    }


    [AttributeUsage(AttributeTargets.All)]
    class CustomAttribute : Attribute { }
}

