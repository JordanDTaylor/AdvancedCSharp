using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main()
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 18, 4 };

            var max = numbers.Max();

            Console.WriteLine(max);

        }
    }
}
