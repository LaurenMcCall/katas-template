using System.Linq;

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            return string.Concat(input.Where(inputs => !char.IsWhiteSpace(inputs)));
        }
    }
}