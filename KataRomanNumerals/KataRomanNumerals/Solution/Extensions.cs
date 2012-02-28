using System.Linq;

namespace Solution
{
    internal static class Extensions
    {
        public static int Count(this string value, char valueToCount)
        {
            return value.Where(i => i == valueToCount).Count();
        }

        public static string Remove(this string orginal, string toRemove)
        {
            return orginal.Replace(toRemove, string.Empty);
        }
    }
}