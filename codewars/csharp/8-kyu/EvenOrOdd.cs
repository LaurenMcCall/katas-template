using System;

namespace Solution
{
  public class SolutionClass
  {
    //            this is the output type
    public static string EvenOrOdd(int number)
    {
      // Code goes here ...given an integer, if the mod 2 = 0, say even, else say odd
      
      // if the number modulus 2 is equal to 0, then the answer is "Even"
     if (number % 2 == 0)
     {
         // the answer is "Even"
         return "Even";
     }
     else
     {
        // else, the answer is "Odd"
        return "Odd";
     }
      
    }
  }
}