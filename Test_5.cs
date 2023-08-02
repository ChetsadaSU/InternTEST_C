using System;

class Program
{
    static void Main()
    {
        Console.Write("input: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 4)
            for (int i = 1, current = 1; i <= number; i++, Console.WriteLine())
                for (int j = 0; j < i; j++, current++)
                    Console.Write(current % 10);
        else
            Console.WriteLine("1-4 only");
        Console.ReadLine();
    }
}