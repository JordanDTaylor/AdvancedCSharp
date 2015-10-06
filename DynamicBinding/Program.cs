
using System;
using System.Runtime.Remoting;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
//            object obj = "Mash";
//            obj.GetHashCode();

//            var methodInfo = obj.GetType().GetMethod("GetHashCode");
//            methodInfo.Invoke(null, null);

//            dynamic excelObject = "excelObject";
//            excelObject.Optimize();

            dynamic name = "Jordan";
            Console.WriteLine(name);

            name = 10;
            Console.WriteLine(name);

            name++;
            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;
            c = "my name";
            Console.WriteLine(c);

        }
    }
}
