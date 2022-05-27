using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //Creating an extension method: static class and methods, 1st parameter of extension method must be of the type which will be extended, 1st parameter must be written after 'this' keyword
    public static class Extension
    {
        public static string EvenOrOdd(this int number)
        {
            if (number%2 ==0)
            {
                return "Even";
            }
            return "Odd";
        }
    }
}
