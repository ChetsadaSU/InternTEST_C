using System;

class Program
{
    static void Main()
    {

        string s1 = "Mary";
        string s2 = "Army";

        Console.WriteLine(AreStringsSimilar(s1, s2));
        Console.ReadLine();
    }

    static bool AreStringsSimilar(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        s1 = s1.ToLower();
        s2 = s2.ToLower();

        char[] s1Array = s1.ToCharArray();
        char[] s2Array = s2.ToCharArray();

        Array.Sort(s1Array);
        Array.Sort(s2Array);

        return new string(s1Array) == new string(s2Array);
    }
}
