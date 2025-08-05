using System;
using System.Collections.Generic;

public class QuadraticTime
{
    public static void PrintAllPairs<T>(List<T> arr)
    {
        // O(n^2) operation: Nested loops
        if (arr == null)
        {
            return;
        }

        Console.WriteLine($"Printing all pairs for list of size {arr.Count}:");
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                // In a real scenario, you'd do something meaningful with the pair
                // For demonstration, we just print a few to illustrate the operation
                if (arr.Count <= 5 || (i < 2 && j < 2)) // Limit printing for very large lists
                {
                    Console.WriteLine($"({arr[i]}, {arr[j]})");
                }
            }
        }
        if (arr.Count > 5)
        {
            Console.WriteLine("... (truncated for brevity due to large number of pairs)");
        }
    }

    public static void Main(string[] args)
    {
        List<int> myList1 = new List<int> { 1, 2, 3 };
        PrintAllPairs(myList1);
        Console.WriteLine(new string('-', 20));

        List<char> myList2 = new List<char> { 'a', 'b', 'c', 'd', 'e' };
        PrintAllPairs(myList2);
        Console.WriteLine(new string('-', 20));

        // A slightly larger list to show the impact of n^2
        List<int> largeList = new List<int>();
        for (int i = 0; i < 10; i++) // 10 elements
        {
            largeList.Add(i);
        }
        // This will perform 10*10 = 100 operations (pairs)
        PrintAllPairs(largeList);
    }
}