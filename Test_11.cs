using System;

class Program
{
    static void Main()
    {
        int[] input = { 1, 2, 9, 4, 5, 8, 7, 6, 3, 10 };
        Console.WriteLine("before: " + string.Join(", ", input));
        BubbleSort(input);
        Console.WriteLine("after: " + string.Join(", ", input));
        Console.ReadLine();
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap the elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
