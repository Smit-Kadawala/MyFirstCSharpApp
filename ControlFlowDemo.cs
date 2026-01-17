using System;

namespace MyApp
{
    /// <summary>
    /// This class demonstrates control flow statements like foreach and if-else.
    /// </summary>
    public static class ControlFlowDemo
    {
        /// <.summary>
        /// Calculates the average of scores and provides feedback.
        /// </summary>
        public static void Show()
        {
            int[] scores = { 85, 92, 78, 95, 88 };
            int total = 0;

            foreach (int score in scores)
            {
                total += score;
            }

            double average = (double)total / scores.Length;
            Console.WriteLine("Average: " + average);

            if (average >= 90)
                Console.WriteLine("Excellent!");
            else if (average >= 80)
                Console.WriteLine("Good job!");
            else
                Console.WriteLine("Keep practicing!");
        }
    }
}
