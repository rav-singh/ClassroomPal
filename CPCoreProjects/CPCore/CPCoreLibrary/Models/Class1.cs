using System;

namespace CPCoreLibrary
{
    public static class Class1
    {
        public static bool StartsWithLower(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            char ch = str[0];
            return char.IsLower(ch);
        }
    }
}
