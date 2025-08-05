using System;

public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
        {
            return;
        }

        int n = arr.Length;

        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the minimum element in unsorted array
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element
            // of the unsorted part (at index i)
            if (minIndex != i) // Only swap if a new minimum was found
            {
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}