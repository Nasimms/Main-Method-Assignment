using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Call int version
            Console.WriteLine("Result with int: " + math.DoMath(20));

            // Call decimal version
            Console.WriteLine("Result with decimal: " + math.DoMath(7.5m));

            // Call string version
            Console.WriteLine("Result with string: " + math.DoMath("30"));

            Console.ReadLine();
        }
    }
}
