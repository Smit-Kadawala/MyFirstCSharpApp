using System;

namespace MyApp
{
    /// <summary>
    /// This class demonstrates the use of the Calculator class.
    /// </summary>
    public static class CalculatorDemo
    {
        /// <summary>
        /// Performs and displays results of basic arithmetic operations.
        /// </summary>
        public static void Show()
        {
            // Create an instance of Calculator class
            Calculator calc = new Calculator();

            int sum = calc.Add(5, 3);
            int difference = calc.Subtract(10, 4);
            int product = calc.Multiply(2, 6);
            double quotient = calc.Divide(15, 3);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}
