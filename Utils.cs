 Utils.csusing System;

namespace SnipeITAutomation
{
    public static class Utils
    {
        private static readonly Random _random = new Random();

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var str = new char[length];
            for (int i = 0; i < length; i++)
                str[i] = chars[_random.Next(chars.Length)];

            return new string(str);
        }
    }
}
