using System;
using System.Collections.Generic;

namespace MyApp
{
    /// <summary>
    /// This class demonstrates the use of Dictionary.
    /// </summary>
    public static class DictionaryDemo
    {
        /// <summary>
        /// Creates a dictionary and prints its contents.
        /// </summary>
        public static void Show()
        {
            // Dictionary of experience
            Dictionary<string, int> experience = new Dictionary<string, int>
            {
                { "React Native", 3 },
                { "JavaScript", 3 },
                { "C#", 0 }
            };

            Console.WriteLine("\nExperience:");
            foreach (var item in experience)
            {
                Console.WriteLine($"{item.Key}: {item.Value} years");
            }
        }
    }
}
