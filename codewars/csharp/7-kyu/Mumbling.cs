// This time no story, no theory. 
//The examples below show you how to write function accum:

// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
public class Accumul
{
    public static String Accum(string s)
    {
        var index = 1;
        var phrase = string.Join("-", s.Select(c => new String(c, index++))).ToLower();
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
    }
}