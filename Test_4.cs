using System;

class Program
{
    static void Main()
    {
        Console.Write("input: ");
        if (int.TryParse(Console.ReadLine(), out int height))
        {
            for (int i = height; i >= 1; i--)
                Console.WriteLine(new string(' ', height - i) + new string('*', 2 * i - 1));
        }
        Console.ReadLine();
    }
}
