
// Complete the solution so that it reverses the string passed into it.

// 'world'  =>  'dlrow'
// 'word'   =>  'drow'

using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str)
    {
        // return new string(str.Reverse());

        // var word = str;

        // var reversedWord = str.Reverse().ToString();
        // return reversedWord;
        return string.Concat(str.ToArray().Reverse());


        // var reversedWord = str.ToString().Reverse();
        // return reversedWord;
    }
}