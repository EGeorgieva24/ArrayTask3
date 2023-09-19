using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;

        // Calculate the sum of all elements in the array
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine($"Sum of all elements in the array: {sum}");
    }
}

