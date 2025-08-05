using System;

public class InsertionSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
        {
            return;
        }

        int n = arr.Length;
        for (int i = 1; i < n; i++) // Start from the second element
        {
            int key = arr[i]; // The element to be inserted into the sorted sub-array
            int j = i - 1;    // Index of the last element in the sorted sub-array

            // Move elements of arr[0...i-1], that are greater than key,
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key; // Place the key at its correct position
        }
    }
}