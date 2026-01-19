using System;
using System.IO;

namespace MyApp
{
    // Custom exception for demonstration
    public class CustomDemoException : Exception
    {
        public CustomDemoException() { }
        public CustomDemoException(string message) : base(message) { }
        public CustomDemoException(string message, Exception innerException) : base(message, innerException) { }
    }

    /// <summary>
    /// This class demonstrates various aspects of exception handling in C#.
    /// </summary>
    public static class ExceptionHandlerDemo
    {
        /// <summary>
        /// Shows different exception handling scenarios.
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("\n--- Exception Handling Demo ---");

            // Scenario 1: Basic try-catch for division by zero
            Console.WriteLine("\n--- Scenario 1: Basic try-catch (Division by Zero) ---");
            Divide(10, 0);

            // Scenario 2: Multiple catch blocks
            Console.WriteLine("\n--- Scenario 2: Multiple Catch Blocks ---");
            ParseAndDivide("abc", 2);
            ParseAndDivide("10", 0);
            ParseAndDivide("20", 5);

            // Scenario 3: Finally block
            Console.WriteLine("\n--- Scenario 3: Finally Block ---");
            DemonstrateFinallyBlock(true);
            DemonstrateFinallyBlock(false);

            // Scenario 4: Throwing and catching custom exception
            Console.WriteLine("\n--- Scenario 4: Throwing and Catching Custom Exception ---");
            TryCustomException(true);
            TryCustomException(false);

            // Scenario 5: Exception filtering (C# 6.0 and later)
            Console.WriteLine("\n--- Scenario 5: Exception Filtering ---");
            DemonstrateExceptionFiltering(5);
            DemonstrateExceptionFiltering(15);
        }

        public static void Divide(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine($"Result of {a} / {b} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a general exception: {ex.Message}");
            }
        }

        public static void ParseAndDivide(string numStr, int divisor)
        {
            try
            {
                int num = int.Parse(numStr);
                int result = num / divisor;
                Console.WriteLine($"Result of {numStr} / {divisor} = {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Caught FormatException: Invalid input string - {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught DivideByZeroException: Cannot divide by zero - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a general exception: {ex.Message}");
            }
        }

        public static void DemonstrateFinallyBlock(bool throwException)
        {
            try
            {
                Console.WriteLine("Inside try block.");
                if (throwException)
                {
                    throw new InvalidOperationException("Demonstrating finally block with exception.");
                }
                Console.WriteLine("End of try block (no exception).");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught exception in catch block: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Inside finally block (always executes).");
            }
        }

        public static void TryCustomException(bool throwIt)
        {
            try
            {
                if (throwIt)
                {
                    throw new CustomDemoException("This is a custom exception!");
                }
                Console.WriteLine("No custom exception thrown.");
            }
            catch (CustomDemoException ex)
            {
                Console.WriteLine($"Caught CustomDemoException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a general exception: {ex.Message}");
            }
        }

        public static void DemonstrateExceptionFiltering(int value)
        {
            try
            {
                if (value > 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Value cannot be greater than 10.");
                }
                Console.WriteLine($"Value is {value}. No filtered exception.");
            }
            catch (ArgumentOutOfRangeException ex) when (ex.ParamName == nameof(value))
            {
                Console.WriteLine($"Caught ArgumentOutOfRangeException (filtered): {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught general exception: {ex.Message}");
            }
        }
    }
}
