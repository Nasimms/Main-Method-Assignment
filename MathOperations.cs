using System;

namespace MainMethodAssignment
{
    public class MathOperations
    {
        // 1. Method that takes an integer and returns an integer after a math operation
        public int DoMath(int number)
        {
            return number + 10; // Example math
        }

        // 2. Overloaded method that takes a decimal, returns an int
        public int DoMath(decimal number)
        {
            return (int)(number * 2); // Different math operation
        }

        // 3. Overloaded method that takes a string, converts to int, returns int
        public int DoMath(string numberString)
        {
            int result;

            // Try to convert string to int
            if (int.TryParse(numberString, out result))
            {
                return result - 5; // Another math operation
            }
            else
            {
                Console.WriteLine("String could not be converted to a number.");
                return 0;
            }
        }
    }
}
