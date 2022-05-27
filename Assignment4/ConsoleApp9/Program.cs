// See https://aka.ms/new-console-template for more information

/** 2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public static class MyList<T> where T : struct
    {
        public static void Add(T element) { }
        public static T Remove(int index) 
        { 
            T n = Remove(index);
            return n;
        }
        public static bool Contains(T element) {
            return element.Equals(element);
        }
        public static void Clear() { }
        public static void InsertAt(T element, int index) { }
        public static void DeleteAt(int index) { }
        public static T Find(int index)
        {
            T element = Find(index);
            return element;
        }
    }
}

