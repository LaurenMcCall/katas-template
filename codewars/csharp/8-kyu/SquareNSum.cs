using System Linq;

public static class Kata
{
    public static int SquareSum(int[] n)
    {
        var squares = Array.ConvertAll(n, i => i * i);

        // var squaredN = n.Select(x => x * x).ToArray();

        // foreach (var squaredN in n)
        // {
        //     squaredN* squaredN;
        // }

        var total = 0;
        foreach (var i in n)
        {
            total += i;
        }
        return total;
    }
}