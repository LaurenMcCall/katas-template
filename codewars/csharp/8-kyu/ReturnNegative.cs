using System;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        // Happy Coding
        if (number > 0)
        {
            number = number * -1;
        }
        else if (number == 0)
        {
            return 0;
        }
        return number;
    }
}