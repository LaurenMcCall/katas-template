using System;
using System.Linq;

public static class Kata
{
    public static int SquareSum(int[] n)
    {
        var squares = Array.ConvertAll(n, i => i * i);

        var total = 0;
        foreach (var i in squares)
        {
            total += i;
        }
        return total;
    }
}