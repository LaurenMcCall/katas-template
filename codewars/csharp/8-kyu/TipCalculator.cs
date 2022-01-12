using System;

public class Kata
{
    public static int CalculateTip(double amount, string rating)
    {
        var tipRate = rating.ToUpper();
        if (tipRate == "TERRIBLE")
        {
            return 0;
        }
        else if (tipRate == "POOR")
        {
            return (int)Math.Ceiling(amount * .05);
        }
        else if (tipRate == "GOOD")
        {
            return (int)Math.Ceiling(amount * .10);
        }
        else if (tipRate == "GREAT")
        {
            return (int)Math.Ceiling(amount * .15);
        }
        else if (tipRate == "EXCELLENT")
        {
            return (int)Math.Ceiling(amount * .20);
        }
        else
        {
            return -1;
        }
    }
}

// Complete the function, which calculates how much you need 
// to tip based on the total amount of the bill and the service.

// You need to consider the following ratings:

// Terrible: tip 0%
// Poor: tip 5%
// Good: tip 10%
// Great: tip 15%
// Excellent: tip 20%
// The rating is case insensitive (so "great" = "GREAT"). 
// If an unrecognised rating is received, then you need to return:

// "Rating not recognised" in Javascript, Python and Ruby...
// ...or null in Java
// ...or -1 in C#
// Because you're a nice person, you always round up the tip, 
// regardless of the service.