public class Multiplier
{
    // This kata is about multiplying a given number 
    // by eight if it is an even number and by nine otherwise.


    public static int Multiply(int x)
    {
        if (x % 2 == 0)
        {
            x = x * 8;
        }
        else
        {
            x = x * 9;
        }
        return x;
    }
}