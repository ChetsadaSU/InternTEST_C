using System;

class Program
{
    static string Revert(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string Revert_Sentence(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
            words[i] = Revert(words[i]);

        return string.Join(" ", words);
    }

    static void Main()
    {
        string input = "Welcome to clicknext";
        Console.WriteLine(Revert_Sentence(input));
        Console.ReadLine();
    }
}