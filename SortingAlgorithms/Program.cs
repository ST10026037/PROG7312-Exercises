using System;
using System.Linq; 

namespace SortingAlgorithms
{
    class Program
    {
        // Helper method to print an array
        static void PrintArray(string description, int[] arr)
        {
            Console.WriteLine($"{description}: [{string.Join(", ", arr)}]");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstrating Sorting Algorithms ---");
            Console.WriteLine("\n");

            // Original array to be sorted
            int[] originalArray = { 64, 34, 25, 12, 22, 11, 90 };
            int[] alreadySortedArray = { 10, 20, 30, 40, 50 };
            int[] reverseSortedArray = { 90, 80, 70, 60, 50 };

            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("\n");

            // --- 1. Optimized Bubble Sort ---
            Console.WriteLine("=== Optimized Bubble Sort ===");
            int[] arrBubble = (int[])originalArray.Clone(); // Create a copy to sort
            Console.WriteLine($"Before Bubble Sort: [{string.Join(", ", arrBubble)}]");
            OptimizedBubbleSort.Sort(arrBubble);
            Console.WriteLine($"After Bubble Sort:  [{string.Join(", ", arrBubble)}]");

            // Test best case
            int[] arrBubbleBest = (int[])alreadySortedArray.Clone();
            Console.WriteLine($"Best Case (sorted) Bubble Sort: [{string.Join(", ", arrBubbleBest)}]");
            OptimizedBubbleSort.Sort(arrBubbleBest);
            Console.WriteLine($"Result (best case):             [{string.Join(", ", arrBubbleBest)}]");

            // Test worst case
            int[] arrBubbleWorst = (int[])reverseSortedArray.Clone();
            Console.WriteLine($"Worst Case (reverse) Bubble Sort: [{string.Join(", ", arrBubbleWorst)}]");
            OptimizedBubbleSort.Sort(arrBubbleWorst);
            Console.WriteLine($"Result (worst case):              [{string.Join(", ", arrBubbleWorst)}]");
            Console.WriteLine("\n");


            // --- 2. Insertion Sort ---
            Console.WriteLine("=== Insertion Sort ===");
            int[] arrInsertion = (int[])originalArray.Clone(); // Create a copy to sort
            Console.WriteLine($"Before Insertion Sort: [{string.Join(", ", arrInsertion)}]");
            InsertionSort.Sort(arrInsertion);
            Console.WriteLine($"After Insertion Sort:  [{string.Join(", ", arrInsertion)}]");

            // Test best case
            int[] arrInsertionBest = (int[])alreadySortedArray.Clone();
            Console.WriteLine($"Best Case (sorted) Insertion Sort: [{string.Join(", ", arrInsertionBest)}]");
            InsertionSort.Sort(arrInsertionBest);
            Console.WriteLine($"Result (best case):                [{string.Join(", ", arrInsertionBest)}]");

            // Test worst case
            int[] arrInsertionWorst = (int[])reverseSortedArray.Clone();
            Console.WriteLine($"Worst Case (reverse) Insertion Sort: [{string.Join(", ", arrInsertionWorst)}]");
            InsertionSort.Sort(arrInsertionWorst);
            Console.WriteLine($"Result (worst case):                 [{string.Join(", ", arrInsertionWorst)}]");
            Console.WriteLine("\n");


            // --- 3. Selection Sort ---
            Console.WriteLine("=== Selection Sort ===");
            int[] arrSelection = (int[])originalArray.Clone(); // Create a copy to sort
            Console.WriteLine($"Before Selection Sort: [{string.Join(", ", arrSelection)}]");
            SelectionSort.Sort(arrSelection);
            Console.WriteLine($"After Selection Sort:  [{string.Join(", ", arrSelection)}]");

            // Test best case (note: complexity is still O(n^2) for selection sort even for sorted input)
            int[] arrSelectionBest = (int[])alreadySortedArray.Clone();
            Console.WriteLine($"Best Case (sorted) Selection Sort: [{string.Join(", ", arrSelectionBest)}]");
            SelectionSort.Sort(arrSelectionBest);
            Console.WriteLine($"Result (best case):                [{string.Join(", ", arrSelectionBest)}]");

            // Test worst case
            int[] arrSelectionWorst = (int[])reverseSortedArray.Clone();
            Console.WriteLine($"Worst Case (reverse) Selection Sort: [{string.Join(", ", arrSelectionWorst)}]");
            SelectionSort.Sort(arrSelectionWorst);
            Console.WriteLine($"Result (worst case):                 [{string.Join(", ", arrSelectionWorst)}]");
            Console.WriteLine("\n");

            Console.WriteLine("--- End of Demonstration ---");
            Console.ReadKey(); // Keep the console window open
        }
    }
}