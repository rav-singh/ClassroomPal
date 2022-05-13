namespace CPCore
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }

        public static string ConvertToLower(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return "";

            return str.ToLower();
        }
    }
}