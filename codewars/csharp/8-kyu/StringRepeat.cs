// Write a function called repeatStr which repeats the given string 
// string exactly n times.

// repeatStr(6, "I") // "IIIIII"
// repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"

namespace Solution
{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string sRepeat = new string('+', n).Replace("+", s);
            return sRepeat;
        }

    }
}
