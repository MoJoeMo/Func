using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncExplained
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            //A func takes in one or more parameters, the last parameter is always an 'out'.
            Func<int, int, int> add = Sum;
            int result = add(9, 90);

            Func<int, string> intToString = s => string.Format("string = {0}", s);
            Func<string, string, string> stringFromString = (s1, s2) => string.Format("String = {0}{1}", s1, s2);

            Console.WriteLine(result);
            Console.WriteLine(intToString(5));
            Console.WriteLine(stringFromString("BO", "OM!"));
            Console.Read();
        }
    }
}
