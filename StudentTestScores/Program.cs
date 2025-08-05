using System;

public class StudentTestScores
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Student Test Scores using Jagged Arrays ---");
        Console.WriteLine("\n");

        // Requirement 1: Declare a jagged array for 3 students
        // int[][] declares a jagged array where each element is an array of integers.
        // We initialize the outer array to hold 3 inner arrays (for 3 students).
        int[][] StudentTestScores = new int[3][]; // The 'new int[3][]' creates 3 "slots" for arrays.

        // Requirement 2: Initialize each student's scores
        // We create a new array for each student and assign it to the corresponding slot.
        // Notice how each inner array can have a different length.

        // Student 1 has 4 scores
        StudentTestScores[0] = new int[] { 85, 92, 78, 95 };

        // Student 2 has 3 scores
        StudentTestScores[1] = new int[] { 70, 88, 81 };

        // Student 3 has 5 scores
        StudentTestScores[2] = new int[] { 65, 72, 80, 75, 90 };

        Console.WriteLine("Scores initialized for 3 students");
        Console.WriteLine("\n");

        // Requirement 3: Display scores
        Console.WriteLine("--- Displaying Student Scores ---");

        // To display, we use nested loops:
        // The outer loop iterates through each student (each inner array).
        for (int i = 0; i < StudentTestScores.Length; i++)
        {
            Console.Write($"Student {i + 1} Scores: "); // i+1 for 1-based student numbering

            // The inner loop iterates through the scores for the current student.
            // studentScores[i].Length gives the number of scores for the current student.
            for (int j = 0; j < StudentTestScores[i].Length; j++)
            {
                Console.Write($"{StudentTestScores[i][j]} ");
            }
            Console.WriteLine(); // Move to the next line after displaying all scores for a student
        }

        Console.WriteLine("\n--- End of Score Display ---");
        Console.ReadKey(); // Keep the console window open
    }
}