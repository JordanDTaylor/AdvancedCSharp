

using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = DateTime.Parse(args[0]);

            //null coalescing operator--
            DateTime date2 = date ?? DateTime.UtcNow;

            Console.WriteLine(date2);
        }
    }
}
