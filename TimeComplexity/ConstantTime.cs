using System;
using System.Collections.Generic;

public class ConstantTime
{
    public static T GetFirstElement<T>(List<T> arr)
    {
        // O(1) operation: Accessing an element by index
        if (arr == null || arr.Count == 0)
        {
            return default(T); // Returns the default value for the type (e.g., 0 for int, null for string)
        }
        return arr[0];
    }

    public static void Main(string[] args)
    {
        List<int> myList1 = new List<int> { 10, 20, 30, 40, 50 };
        Console.WriteLine($"First element of [{string.Join(", ", myList1)}]: {GetFirstElement(myList1)}");

        List<int> myList2 = new List<int> { 1 };
        Console.WriteLine($"First element of [{string.Join(", ", myList2)}]: {GetFirstElement(myList2)}");

        List<int> myList3 = new List<int>();
        Console.WriteLine($"First element of []: {GetFirstElement(myList3)}");
    }
}