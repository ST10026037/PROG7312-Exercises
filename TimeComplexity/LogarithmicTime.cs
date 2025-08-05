using System;
using System.Collections.Generic;

public class LogarithmicTime
{
    public static int BinarySearch(List<int> arr, int target)
    {
        // O(log n) operation: Binary search
        if (arr == null)
        {
            return -1;
        }

        int left = 0;
        int right = arr.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Prevents potential overflow for very large left/right

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; // Target not found
    }

    public static void Main(string[] args)
    {
        List<int> sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine($"Index of 7 in [{string.Join(", ", sortedList)}]: {BinarySearch(sortedList, 7)}");
        Console.WriteLine($"Index of 11 in [{string.Join(", ", sortedList)}]: {BinarySearch(sortedList, 11)}");

        // Create a large sorted list
        List<int> largeSortedList = new List<int>();
        for (int i = 1; i <= 1000000; i++)
        {
            largeSortedList.Add(i);
        }
        Console.WriteLine($"Index of 999999 in largeSortedList: {BinarySearch(largeSortedList, 999999)}");
    }
}