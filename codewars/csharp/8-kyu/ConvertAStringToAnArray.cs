using System;
using System.Linq;

namespace Solution
{
    using System;

    public class Solution
    {
        public static string[] StringToArray(string str)
        {
            // return str.ToCharArray().Select(x => x.ToString().ToArray());
            var result = str.Trim('[', ']').Split(",").Select(x => x.Trim('"')).ToArray();
            return result;
        }

    }
}