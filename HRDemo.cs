using System;
using MyCompany.HR; // Import the namespace for Employee and Developer

namespace MyApp
{
    /// <summary>
    /// This class demonstrates the use of HR-related classes.
    /// </summary>
    public static class HRDemo
    {
        /// <summary>
        /// Creates instances of Employee and Developer and shows their info.
        /// </summary>
        public static void Show()
        {
            // Create an instance of Employee class
            Employee emp = new Employee();
            emp.Name = "Alice";
            emp.Experience = 5;
            emp.ShowInfo();  // Output: Alice - 5 years

            // Create an instance of Developer class
            Developer dev = new Developer();
            dev.TechStack = "C# and .NET";
            dev.Code();  // Output: Writing code in C# and .NET
        }
    }
}
