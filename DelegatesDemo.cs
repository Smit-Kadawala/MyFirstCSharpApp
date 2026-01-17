using System;
using System.Threading;

namespace MyApp
{
    // Define a delegate for a notification message
    public delegate void NotificationHandler(string message);

    /// <summary>
    /// This class demonstrates the use of delegates, including as callbacks.
    /// </summary>
    public static class DelegatesDemo
    {
        /// <summary>
        /// Shows various examples of delegates.
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("\n--- Delegates Demo ---");

            // 1. Instantiate the delegate with a named method
            NotificationHandler notify = SendEmail;
            notify("This is a notification using a named method.");

            // 2. Instantiate the delegate with a lambda expression
            notify = message => Console.WriteLine($"Sending SMS: {message}");
            notify("This is a notification using a lambda expression.");
            
            // 3. Using a delegate for a callback
            Console.WriteLine("\n--- Delegate as Callback Demo ---");
            PerformLongRunningTask(ProcessCompleted);
        }

        // Method that matches the delegate signature
        public static void SendEmail(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }

        /// <summary>
        /// A method that takes a delegate as a parameter (a callback).
        /// This method simulates a long-running task.
        /// </summary>
        /// <param name="callback">The delegate to call upon completion.</param>
        public static void PerformLongRunningTask(NotificationHandler callback)
        {
            Console.WriteLine("Starting a long-running task...");
            Thread.Sleep(2000); // Simulate work for 2 seconds
            Console.WriteLine("Task completed.");
            
            // Call the callback to notify the caller
            callback("The long-running task has finished.");
        }

        // This is the callback method that will be passed to PerformLongRunningTask
        public static void ProcessCompleted(string message)
        {
            Console.WriteLine($"Callback received! Message: {message}");
        }
    }
}
