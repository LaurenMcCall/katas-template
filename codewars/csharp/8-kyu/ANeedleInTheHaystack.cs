using System;
using System.Linq;

public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        // var needle = "needle";
        int index = Array.FindIndex(haystack, x => x == "needle");

        return $"found the needle at position {index}";
    }
}