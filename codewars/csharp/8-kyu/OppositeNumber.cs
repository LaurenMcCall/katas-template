using System;

public class Kata
{
    public static int Opposite(int number)
    {
        // Happy Coding
        if (number < 0)
        {
            return number * 1;
        }
        else if (number > 0)
        {
            return number * (-1);
        }
        else
        {
            return number;
        }
    }
}