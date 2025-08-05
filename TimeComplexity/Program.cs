using System;
using System.Collections.Generic;

namespace TimeComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Demonstrating Time Complexities ---");
            Console.WriteLine("\n");

            // --- 1. Constant Time (O(1)) ---
            Console.WriteLine("=== Constant Time (O(1)) ===");
            List<int> constList1 = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine($"First element of [{string.Join(", ", constList1)}]: {ConstantTime.GetFirstElement(constList1)}");

            List<int> constList2 = new List<int> { 1 };
            Console.WriteLine($"First element of [{string.Join(", ", constList2)}]: {ConstantTime.GetFirstElement(constList2)}");

            List<int> constList3 = new List<int>();
            Console.WriteLine($"First element of []: {ConstantTime.GetFirstElement(constList3)}");
            Console.WriteLine("\n");


            // --- 2. Logarithmic Time (O(log n)) ---
            Console.WriteLine("=== Logarithmic Time (O(log n)) ===");
            List<int> logList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Index of 7 in [{string.Join(", ", logList)}]: {LogarithmicTime.BinarySearch(logList, 7)}");
            Console.WriteLine($"Index of 11 in [{string.Join(", ", logList)}]: {LogarithmicTime.BinarySearch(logList, 11)}");

            List<int> largeSortedList = new List<int>();
            for (int i = 1; i <= 1000000; i++)
            {
                largeSortedList.Add(i);
            }
            Console.WriteLine($"Index of 999999 in largeSortedList: {LogarithmicTime.BinarySearch(largeSortedList, 999999)}");
            Console.WriteLine("\n");


            // --- 3. Linear Time (O(n)) ---
            Console.WriteLine("=== Linear Time (O(n)) ===");
            List<int> linearList1 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum of elements in [{string.Join(", ", linearList1)}]: {LinearTime.SumOfElements(linearList1)}");

            List<int> linearList2 = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine($"Sum of elements in [{string.Join(", ", linearList2)}]: {LinearTime.SumOfElements(linearList2)}");

            List<int> largeLinearList = new List<int>();
            for (int i = 1; i <= 1000000; i++)
            {
                largeLinearList.Add(i);
            }
            Console.WriteLine($"Sum of elements in largeLinearList: {LinearTime.SumOfElements(largeLinearList)}");
            Console.WriteLine("\n");


            // --- 4. Quadratic Time (O(n^2)) ---
            Console.WriteLine("=== Quadratic Time (O(n^2)) ===");
            List<int> quadraticList1 = new List<int> { 1, 2, 3 };
            QuadraticTime.PrintAllPairs(quadraticList1);
            Console.WriteLine(new string('-', 20));

            List<char> quadraticList2 = new List<char> { 'a', 'b', 'c', 'd', 'e' };
            QuadraticTime.PrintAllPairs(quadraticList2);
            Console.WriteLine(new string('-', 20));

            List<int> largeQuadraticList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                largeQuadraticList.Add(i);
            }
            QuadraticTime.PrintAllPairs(largeQuadraticList);
            Console.WriteLine("\n");


            // --- 5. Exponential Time (O(2^n)) ---
            Console.WriteLine("=== Exponential Time (O(2^n)) ===");
            Console.WriteLine($"Fibonacci(0): {ExponentialTime.FibonacciRecursive(0)}");
            Console.WriteLine($"Fibonacci(1): {ExponentialTime.FibonacciRecursive(1)}");
            Console.WriteLine($"Fibonacci(5): {ExponentialTime.FibonacciRecursive(5)}");
            Console.WriteLine($"Fibonacci(10): {ExponentialTime.FibonacciRecursive(10)}");
            // Be very careful uncommenting these lines, they can take a long time!
            // Console.WriteLine($"Fibonacci(20): {ExponentialTime.FibonacciRecursive(20)}");
            // Console.WriteLine($"Fibonacci(30): {ExponentialTime.FibonacciRecursive(30)}");
            Console.WriteLine("\n");

            Console.WriteLine("--- End of Demonstration ---");
            Console.ReadKey(); // Keep the console window open until a key is pressed
        }
    }
}