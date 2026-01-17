using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    /// <summary>
    /// This class demonstrates the use of lambda expressions.
    /// </summary>
    public static class LambdaDemo
    {
        /// <summary>
        /// Shows various examples of lambda expressions.
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("\n--- Lambda Expressions Demo ---");

            // 1. Lambda with a single parameter for a math operation
            Func<int, int> square = (x) => x * x;
            Console.WriteLine($"The square of 5 is: {square(5)}");

            // 2. Using a lambda with List.FindAll
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = numbers.FindAll(n => (n % 2) == 0);

            Console.WriteLine("Even numbers from the list:");
            evenNumbers.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            // 3. Lambda with no parameters
            Action greet = () => Console.WriteLine("Hello from a lambda with no parameters!");
            greet();

            // 4. Lambda with multiple parameters
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Sum of 10 and 20 is: {add(10, 20)}");
        }
    }
}
