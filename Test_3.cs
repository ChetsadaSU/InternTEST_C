using System;

class Program
{
    static void Main()
    {
        int[] dateArray = { 1, 4, 6, 9, 10, 14, 16, 17 };
        string result = PrintDate(dateArray);
        Console.WriteLine(result);
    }

    static string PrintDate(int[] dateArray)
    {
        Array.Sort(dateArray);
        string result = dateArray[0].ToString();
        bool isConsecutive = false;

        for (int i = 1; i < dateArray.Length; i++)
        {
            if (dateArray[i] == dateArray[i - 1] + 1)
            {
                if (!Consecutive)
                {
                    result += "-";
                    Consecutive = true;
                }
            }
            else
            {
                if (Consecutive)
                {
                    result += dateArray[i - 1];
                    Consecutive = false;
                }

                result += ", " + dateArray[i];
            }
        }

        if (Consecutive)
        {
            result += dateArray[dateArray.Length - 1];
        }

        return result;
    }
}
