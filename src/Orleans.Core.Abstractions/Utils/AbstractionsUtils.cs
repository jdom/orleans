using System;

namespace Orleans.Runtime
{
    internal static class AbstractionsUtils
    {
        /// <summary>
        /// Get the last characters of a string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string Tail(this string s, int count)
        {
            return s.Substring(Math.Max(0, s.Length - count));
        }
    }
}
