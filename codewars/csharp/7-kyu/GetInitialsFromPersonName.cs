using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static string toInitials(string name)
        {
            string initials = string.Join(". ", name.Split(' ').Select(x => x[0]).ToArray());

            return initials += ".";
        }
    }
}