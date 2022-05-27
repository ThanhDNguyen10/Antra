using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class Addition
    {
        //Method overloading--compile time polymorphism
        public static int AddNumbers (int a , int b)
        {
            return a + b;
        }
        public static double AddNumbers (double a, double b)
        {
            return a + b;
        }
        public static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
