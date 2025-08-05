using System;

public class ExponentialTime
{
    public static long FibonacciRecursive(int n)
    {
        // O(2^n) operation: Naive recursive Fibonacci
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Fibonacci(0): {FibonacciRecursive(0)}");
        Console.WriteLine($"Fibonacci(1): {FibonacciRecursive(1)}");
        Console.WriteLine($"Fibonacci(5): {FibonacciRecursive(5)}");
        Console.WriteLine($"Fibonacci(10): {FibonacciRecursive(10)}");

        // Be cautious with larger values of n, as execution time grows very rapidly
        // Console.WriteLine($"Fibonacci(20): {FibonacciRecursive(20)}"); // This will take noticeably longer
        // Console.WriteLine($"Fibonacci(30): {FibonacciRecursive(30)}"); // This will take a significant amount of time
        // Console.WriteLine($"Fibonacci(40): {FibonacciRecursive(40)}"); // This will take a very long time, possibly minutes or more
    }
}