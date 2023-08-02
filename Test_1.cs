using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int sum = 5;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == sum)
                {
                    Console.WriteLine($"{array[i]},{array[j]}");
                    
                }
            }
        }
        Console.ReadLine();
    }
}