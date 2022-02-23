using System.Linq;

public class Kata
{
    public static string Shortcut(string input)
    {
        string vowels = "aeiou";
        var name = new string(input.Where(words => !vowels.Contains(words)).ToArray());
        return name;
    }
}