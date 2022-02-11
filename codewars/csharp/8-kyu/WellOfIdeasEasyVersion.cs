using System.Linq;

public class Kata

{
    public static string Well(string[] x)
    {
        var xContains = x.Count(x => x.Contains("good"));

        if (xContains >= 1 && xContains <= 2)
        {
            return "Publish!";
        }
        else if (xContains > 2)
        {
            return "I smell a series!";
        }
        else
        {
            return "Fail!";
        }
    }
}
// For every good kata idea there seem to be quite a few bad ones!

// In this kata you need to check the provided array (x) 
// for good ideas 'good' and bad ideas 'bad'. 
// If there are one or two good ideas, return 'Publish!', 
// if there are more than 2 return 'I smell a series!'. 
// If there are no good ideas, as is often the case, return 'Fail!'.

