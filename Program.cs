// See https://aka.ms/new-console-template for more information

//Max and Min of each type: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
/**
Console.WriteLine("Minimum value of byte: " + byte.MinValue);
Console.WriteLine("Maximum value of byte: " + byte.MaxValue);

Console.WriteLine("Minimum value of sbyte: " + sbyte.MinValue);
Console.WriteLine("Maximum value of sbyte: " + sbyte.MaxValue);

Console.WriteLine("Minimum value of short: " + short.MinValue);
Console.WriteLine("Maximum value of short: " + short.MaxValue);

Console.WriteLine("Minimum value of ushort: " + ushort.MinValue);
Console.WriteLine("Maximum value of ushort: " + ushort.MaxValue);

Console.WriteLine("Minimum value of int: " + int.MinValue);
Console.WriteLine("Maximum value of int: " + int.MaxValue);

Console.WriteLine("Minimum value of uint: " + uint.MinValue);
Console.WriteLine("Maximum value of uint: " + uint.MaxValue);

Console.WriteLine("Minimum value of long: " + long.MinValue);
Console.WriteLine("Maximum value of long: " + long.MaxValue);

Console.WriteLine("Minimum value of ulong: " + ulong.MinValue);
Console.WriteLine("Maximum value of ulong: " + ulong.MaxValue);

Console.WriteLine("Minimum value of float: " + float.MinValue);
Console.WriteLine("Maximum value of float: " + float.MaxValue);

Console.WriteLine("Minimum value of double: " + double.MinValue);
Console.WriteLine("Maximum value of double: " + double.MaxValue);

Console.WriteLine("Minimum value of decimal: " + decimal.MinValue);
Console.WriteLine("Maximum value of decimal: " + decimal.MaxValue);
*/

//Convert century/s to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds. 
/**namespace ConsoleApp1;
using System;
public class Exercise
{
    public static int centuryToYears(int century)    {
        return (century * 100);
    }
    public static int centuryToDays(int century)    {
        return (century * 100 * 365);
    }
    public static int centuryToHours(int century)
    {
        return (century * 100 * 365 * 24);
    }
    public static int centuryToMinutes(int century)
    {
        return (century * 100 * 365 * 24 * 60);
    }
    public static int centuryToSeconds(int century)
    {
        return (century * 100 * 365 * 24 * 60 * 60);
    }
    public static int centuryToMiliseconds(int century)
    {
        return (century * 100 * 365 * 24 * 60 * 60 * 60);
    }
    public static int centuryToMicroseconds(int century)
    {
        return (century * 100 * 365 * 24 * 60 * 60 * 60 * 60);
    }
    public static int centuryToNanoseconds(int century)
    {
        return (century * 100 * 365 * 24 * 60 * 60 * 60 * 60 * 60);
    }
    public static void Main()
    {
        int century = 0;
        Console.WriteLine("Number of century/s: ");
        century = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("In years: " + centuryToYears(century));
        Console.WriteLine("In days: " + centuryToDays(century)); 
        Console.WriteLine("In hours: " + centuryToHours(century));
        Console.WriteLine("In minutes: " + centuryToMinutes(century));
        Console.WriteLine("In seconds: " + centuryToSeconds(century));
        Console.WriteLine("In miliseconds: " + centuryToMiliseconds(century));
        Console.WriteLine("In microseconds: " + centuryToMicroseconds(century));
        Console.WriteLine("In nanoseconds: " + centuryToNanoseconds(century));
    }

}*/
/**
1. What happens when you divide an int variable by 0? Receive an error of division by zero
2. What happens when you divide a double variable by 0? The result is infinity
3. What happens when you overflow an int variable, that is, set it to a value beyond its range? Any exceed number will get rolled over.
4. What is the difference between x = y++; and x = ++y;? ++i means that when your code is executing it will first do i = i + 1 and then read it. 
    i++ means that when your code is executing it will first read it and do the i = i + 1 after it has been read.
5. What is the difference between break, continue, and return when used inside a loop
statement? The break statement transfers control to the statement that follows the terminated statement, if any. 
    The continue statement starts a new iteration of the closest enclosing iteration statement.
    The return statement terminates execution of the function in which it appears and returns control and the function's result, if any, to the caller.
6. What are the three parts of a for statement and which of them are required? initializer, condition, iterator. Initializer and condition are required.
7. What is the difference between the = and == operators ? The == operators is equality that check if their operands are equal. The = is assign value.
8.Does the following statement compile? for ( ; true; ) ; 
    It does compile
9. What does the underscore _ represent in a switch expression? replaces the default keyword to signify that it should match anything if reached
10. What interface must an object implement to be enumerated over by using the foreach statement?
    The foreach statement executes a statement or a block of statements for each element in an instance of the type that implements 
    the System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T> interface
*/
//Console.WriteLine("Maximum value of int: " + int.MaxValue);
//Console.WriteLine(1.2/0);
//for (; true;) ;

/**FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/. */
/**namespace ConsoleApp1;
using System;
public class Exercise3 {
    public static void Main()
    {
        String word = "";

        for (int x = 0; x < 100; x++)
        {
            if (x % 3 == 0 && x % 5 == 0)
            {
                word = "fizzbuzz";
            } 
            else if (x % 3 == 0) {
                word = "fizz";
            }
            else if (x % 5 == 0)
            {
                word = "buzz";
            }
        }
        Console.WriteLine(word);
    }
}
*/
/** Create a console application and enter the preceding code. Run the console application
and view the output. */
/**
namespace ConsoleApp1;
using System;
public class Exercise3 
{
    public static void Main()
    {
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            //WriteLine(i);  //Received error because WriteLine does not exist
            Console.WriteLine(i);
        }
    }
}
*/

/** Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3).
*/
/**
namespace ConsoleApp1;
using System;
public class Exercise
{
    public static void Main()
    {
        int correctNumber = new Random().Next(3) + 1;

        int guessedNumber = int.Parse(Console.ReadLine());

        do
        {
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("The given number is outside the guessing range.");
            }
            else if (guessedNumber == correctNumber)
            {
                Console.WriteLine("Correct!");
            }
            else if (correctNumber > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            guessedNumber = int.Parse(Console.ReadLine());
        } while (correctNumber != guessedNumber);
    }
}
*/

/** Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars. */
/**namespace ConsoleApp1;
using System;
public class Exercise
{
    public static void Main()
    {
        int layer = 5, Space, Sign;
        char c = '*';
        for (int x = 1; x <= layer; x++) // Total number of layer for pramid  
        {
            for (Space = 1; Space <= (layer - x); Space++) // Loop For Space  
                Console.Write(" ");
            for (Sign = 1; Sign <= x; Sign++) //increase the value  
                Console.Write(c);
            for (Sign = (x - 1); Sign >= 1; Sign--) //decrease the value  
                Console.Write(c);
            Console.WriteLine();
        }
    }
}*/

/** Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000); */
/**namespace ConsoleApp1;
using System;
public class Exercise4
{
    public static void Main()
    {
        DateTime today = DateTime.Today;
        DateTime bday = DateTime.Parse(Console.Write);-
        /**int dateBirth = int.Parse(Console.ReadLine("Date of Birth:"));
        int dob = int.Parse(dateBirth.ToString("yyyyMMdd"));
        int birthYear = dob.Year;
        var today = DateTime.Today;
        int year = today.Year;
        Console.WriteLine(year);  */

// Calculate the age.
//var age = today.Year - birthdate.Year;

// Go back to the year in which the person was born in case of a leap year
//if (birthdate.Date > today.AddYears(-age)) age--;

/**Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night" */
/**
namespace ConsoleApp1;
using System;
public class Exercise4
{
    public static void Main()
    {
        DateTime t1 = DateTime.Now;

        if (t1.Hour >= 4 && t1.Hour < 12)
        {
            Console.WriteLine("Good Morning!");
        }
        if (t1.Hour >= 12 && t1.Hour < 16)
        {
            Console.WriteLine("Good Afternoon!");
        }
        if (t1.Hour >= 16 && t1.Hour < 21)
        {
            Console.WriteLine("Good Evening!");
        }
        if (t1.Hour >= 21 && t1.Hour < 4)
        {
            Console.WriteLine("Good Evening!");
        }
    }
}*/

/**Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable. */
/**namespace ConsoleApp1;
using System;
public class Exercise4
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i+=1)
        {
            Console.WriteLine(i);
            for (int j = 0; j <= 14; j+=i)
            {
                Console.WriteLine(j);
            }
        }
    }
}*/