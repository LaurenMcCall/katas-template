using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        // Your code here
        return arr.Where(number => number > 0).Sum(number => number);
    }
}
