using System;

namespace Test
{
    class Testprogram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world! Write something below: ");
            string msg = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your input: " + msg);
        }
    }
}
