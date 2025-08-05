using System;
using System.Collections.Generic;
using System.Linq; // For Sum() in Main method for comparison

public class LinearTime
{
    public static int SumOfElements(List<int> arr)
    {
        // O(n) operation: Iterating through each element once
        if (arr == null)
        {
            return 0;
        }

        int total = 0;
        foreach (int element in arr)
        {
            total += element;
        }
        return total;
    }

    public static void Main(string[] args)
    {
        List<int> myList1 = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Sum of elements in [{string.Join(", ", myList1)}]: {SumOfElements(myList1)}");

        List<int> myList2 = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        Console.WriteLine($"Sum of elements in [{string.Join(", ", myList2)}]: {SumOfElements(myList2)}");

        // Create a large list
        List<int> largeList = new List<int>();
        for (int i = 1; i <= 1000000; i++)
        {
            largeList.Add(i);
        }
        Console.WriteLine($"Sum of elements in largeList (first 5 elements shown) : {SumOfElements(largeList)} (actual sum of 1 to 1,000,000)");
        // Or using LINQ for a concise sum: largeList.Sum()
    }
}