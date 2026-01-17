using System;
using System.Collections.Generic;

namespace MyApp
{
    /// <summary>
    /// This class demonstrates the use of List.
    /// </summary>
    public static class ListDemo
    {
        /// <summary>
        /// Creates a list of skills, adds a new skill, and prints the list.
        /// </summary>
        public static void Show()
        {
            // List of technologies
            List<string> skills = new List<string>
            {
                "React Native", "JavaScript", "TypeScript", "Firebase"
            };

            // Add new skill
            skills.Add("C#");

            Console.WriteLine("My Skills:");
            foreach (string skill in skills)
            {
                Console.WriteLine("- " + skill);
            }
        }
    }
}
