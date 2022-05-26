﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/**
1.When to use String vs. StringBuilder in C# ?
2. What is the base class for all arrays in C#?
3.How do you sort an array in C#?
4.What property of an array object can be used to get the total number of elements in
an array?
5. Can you store multiple data types in System.Array?
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
*/
/**using System;
namespace ConsoleApp3;
public class Assign2
{
    public static void Main ()
    {
        String[] items = { "int", "boolean", "double", "float", "long", "date", "array", "String","Assign","System" };
        String[] secItems = new string[items.Length];
        for (int x =0; x<items.Length; x++)
        {
            secItems[x] = items[x];
            Console.WriteLine(secItems[x]);
        }
        //foreach (String item in items) { Console.WriteLine(item); }
    }
}
*/

/**Write a simple program that lets the user manage a list of elements.It can be a grocery list,
"to do" list, etc.Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop.Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list.The operations available should
be Add, Remove, and Clear. */
/**
using System;
namespace ConsoleApp3;
public class Assign2Q2
{
    public static void Main()
    {
        String[] grocery = { "Beef", "Pork", "Chicken" };
        String userInput = "";
        Console.WriteLine("Enter command (+ item, - item, or -- to clear)): ");
        userInput = Console.ReadLine();

        var oper = "";
        var item = "";

        int len = grocery.Length;
        if (userInput.Length > 2) { 
            oper = userInput.Split(' ')[0];
            item = userInput.Split(' ')[1];
        }

        if (oper == "+")
        {
            Array.Resize(ref grocery, len + 1);
            grocery[grocery.Length - 1] = item;
        }
        else if (oper == "-")
        {
            for (int m = 0; m < grocery.Length; m++)
            {
                if (grocery[m] == item)
                {
                    grocery[m] = grocery[m + 1];
                }
            }
        }
        else if (userInput == "__")
        {
            grocery = null;
        }

        if (grocery != null)
        {
            foreach (String outp in grocery) { Console.WriteLine(outp); }
        }
    } 
} */

/**Write a method that calculates all prime numbers in given range and returns them as array
of integers */
/**
using System;
namespace ConsoleApp3;
public class Assign2Q3
{
    public static void Main()
    {
        int a,b, c, d;
        Console.WriteLine("Start number: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("End number: ");
        b = int.Parse(Console.ReadLine());

        FindPrimesInRange(a,b);
        Console.WriteLine(FindPrimesInRange);
    }
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        int[] primes= new int[endNum];
        for (int x = startNum; x < endNum; x++)
        {
            if (x == 1 || x == 0)
            {
                continue;
            }
            for (int z = x+1; z <= x / 2; ++z)
            {
                if (x % z == 0)
                {
                    primes[z] = x;
                    break;
                }
            }
        }
        return primes;
    }
}*/

/** Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1. */
/**
using System;
namespace ConsoleApp3;
public class Assign2Q4
{
    public static void Main()
    {
        int k = 0; int index = 0; 
        Console.WriteLine("Rotate amount: ");
        k = int.Parse(Console.ReadLine());
        
        int[] arr = new int[4];
        int len = arr.Length;
        k = k % len;

        int[] nArr = new int[len];

        do
        {
            Console.WriteLine("Enter a number: ");
            arr[index] = int.Parse(Console.ReadLine());
            index++;
        } while (index != arr.Length);  

        for (int i = 0; i < len; i++)
        {
            if (i < k)
            {
                Console.Write(nArr[i] = arr[len+i - k]);
            } else {
                Console.Write(nArr[i] = arr[i - k]);
            }
        }

        //foreach (int outp in nArr) { Console.WriteLine(outp); }
    }
}*/

/**Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one */
/**
using System;
namespace ConsoleApp3;
public class Assign2Q5
{
    public static void Main()
    {
        int count = 0; int longestCount = 0;

        Console.WriteLine("How long is the sequence: ");
        int len = int.Parse(Console.ReadLine());

        int[] nums = new int[len];
        int longest = nums[0];

        for (int i = 0; i < len; i++) { 
            Console.WriteLine("Enter a number: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < len; i++)
        {
            if (nums[i] != nums[i-1])
            {
                count = 0;
            }
            count++;    
            if (count > longestCount)
            {
                longestCount = count;
                longest = nums[i];
            }
        }
        Console.WriteLine(longest);
    }
} */
/** Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them */
/**
using System;
using System.Collections.Generic;
namespace ConsoleApp3;
public class Assign2Q7
{
    public static void Main()
    {
        Console.WriteLine("How long is the sequence: ");
        int len = int.Parse(Console.ReadLine());

        int[] nums = new int[len];
        int[] sNums = new int[len];
        int longest = nums[0];
        int potential = nums[0];

        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Enter a number: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums);

        for (int i = 0; i < len; i++)
        {
            var dict = new Dictionary<int, int>();
            foreach (var value in nums)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
            Console.ReadKey();
        }
    }
} */

/**Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop*/
/*
using System;
using System.Collections.Generic;
namespace ConsoleApp3;
public class Assign2Q1B
{
    public static void Main()
    {
        Console.WriteLine("Input: ");
        String word = Console.ReadLine();
        Reverse(word);
        Console.WriteLine(Reverse(word));

        String str = new String(Reverse(word));
        Console.WriteLine(str);
    }
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    /*public string Reverse(string text)
    {   
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    } 
}*/

/**Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are
considered valid words.
The sentences always start by word and end by separator. */
/**using System;
using System.Collections.Generic;
namespace ConsoleApp3;
public class Assign2Q2B
{
    public static void Main()
    {
        String word = "C# is not C++, and PHP is not Delphi!";
        string[] a = word.Split(' ');
        Array.Reverse(a);
        Console.WriteLine(word);

        foreach (String a2 in a) { Console.WriteLine(a2); }
    }
} */

/** Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted*/
/**
using System;
using System.Text.RegularExpressions;
namespace ConsoleApp3;
public class Assign2Q3B
{
    public static void Main()
    {
        String word = "Hi, exe? ABBA! Hog fully a string: ExE.Bob";

        var woChar = Regex.Replace(word, @"[!?:\.,_]", " ");
        string reverse = string.Empty;
        String str = new String(woChar);
        string[] a = woChar.Split(' ');
        string final = "";

        for (int j = 0; j < a.Length; j++)
        {
            for (int i = a[j].Length - 1; i >= 0; i--)
            {
                reverse += woChar[i];
            }
            if (reverse == str)
            {
                final = word[j] +", ";
            }
            //foreach (String a2 in a) { Console.WriteLine(a2); }
        }
        Console.WriteLine(final);
    }
}
*/
/** Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional*/
/**
using System;
namespace ConsoleApp3;
public class Assign2Q2B
{
    public static void Main()
    {
        Console.WriteLine("URL: ");
        String URL = Console.ReadLine();
        int colon = URL.IndexOf(":");
        
        int slash = URL.IndexOf('/', URL.IndexOf('/') + 1);
        int slashes = URL.IndexOf('/', URL.IndexOf('/') + 2);
        
        Console.WriteLine("Protocol: " +URL.Substring(0,colon) +"\nServer: "+URL.Substring(slash+1,slashes-(slash+1)));
    }
}
*/