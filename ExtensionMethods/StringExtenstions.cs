using System.Linq;

namespace System
{
    public static class StringExtenstions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if(numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to zero");

            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}