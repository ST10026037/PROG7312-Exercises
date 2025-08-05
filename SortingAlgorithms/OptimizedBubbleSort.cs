using System;

public class OptimizedBubbleSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
        {
            return; // Already sorted or nothing to sort
        }

        int n = arr.Length;
        bool swapped; // Flag for optimization

        for (int i = 0; i < n - 1; i++) // Outer loop for passes
        {
            swapped = false; // Reset flag for each pass
            // Inner loop compares adjacent elements and swaps them
            // The (n - 1 - i) part means we don't need to check the last 'i' elements
            // because they are already in their correct sorted position.
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true; // A swap occurred
                }
            }

            // If no two elements were swapped by inner loop, then array is sorted
            if (!swapped)
            {
                break; // Optimization: Exit early if no swaps happened in a pass
            }
        }
    }
}