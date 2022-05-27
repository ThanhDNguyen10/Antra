﻿/**1.What are the six combinations of access modifier keywords and what do they do?   
    public(accessiable from everywhere in the project), private(accessible from inside the class), internal(limited to classes defined within the current project), 
    protected(accessible inside the class and all classes that derive from that class),
    protected internal(access the protected internal member only in the same assembly or in a derived class in other assemblies), 
    private protected(access members inside the containing class or in the derives class from a containing class)
2.What is the difference between the static, const, and readonly keywords when applied to a type member? The first, const, is initialized during compile-time and the latter, readonly, initialized is by the latest run-time. 
    The second difference is that readonly can only be initialized at the class-level. 
    Another important difference is that const variables can be referenced through "ClassName.VariableName", while readonly can be referenced through "InstanceName.VariableName".
3. What does a constructor do? constructor is used to create an object of the class and initialize class members
4. Why is the partial keyword useful? indicates that other parts of the class, struct, or interface can be defined in the namespace
5. What is a tuple? a data structure which consists of the multiple parts
6. What does the C# record keyword do? define a reference type that provides built-in functionality for encapsulating data
7. What does overloading and overriding mean? Method overriding: Methods in base class and its subclasses share the same method name and same input parameters. 
    Keyword: Virtual / Abstract in base class methods; Override in derived class methods. Runtime polymorphism
    Method overloading: Methods in same class share the same method name, but different input parameters. Compile time polymorphism
8. What is the difference between a field and a property? field is a variable of any type that is declared directly in the class while property is a member that provides a flexible mechanism to read, write or compute the value of a private field
9. How do you make a method parameter optional? By assigning default values for that parameter
10. What is an interface and how is it different from abstract class? Abstract Class is always a based class and marked with abstract keyword. It can not be instantiated
    It can have both abstract and concrete methods. It can have constructors, fields and public/protected/private members. One class can inherit only one Abstract class
11.What accessibility level are members of an interface? public
12.True / False.Polymorphism allows derived classes to provide different implementations of the same method. True
13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method. True
14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method. False
15. True/False. Abstract methods can be used in a normal (non-abstract) class. False
16. True / False.Normal(non -abstract) methods can be used in an abstract class. True
17.True / False. Derived classes can override methods that were virtual in the base class. True
18.True / False. Derived classes can override methods that were abstract in the base class. True
19.True / False. In a derived class, you can override a method that was neither virtual non abstract in the base class. False
20.True / False.A class that implements an interface does not have to provide an implementation for all of the members of the interface. False
21.True / False.A class that implements an interface is allowed to have other members that aren’t defined in the interface. True
22.True / False.A class can have more than one base class. False
23.True / False.A class can implement more than one interface. True
*/

/**Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end */
/**using System;
namespace Assignment3;
public class Assignment3
{
    public static void Main(String[] args)
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(Reverse(numbers));
    }
    public static int[] GenerateNumbers()
    {
        int[] numArr = new int[5];
        for (int i = 0; i < numArr.Length; i++)
        {
            Console.WriteLine("Enter a number: ");
            numArr[i] = Convert.ToInt32(Console.ReadLine());
        }
        return numArr;
    }
    public static int[] Reverse(int[] num) 
    {
        int[] x = new int[num.Length];
        for (int i = 0; i<num.Length; i++)
        {
            x[num.Length-1-i] = num[i];
        }
        return x;
    }
    public static void PrintNumbers(int[] num)
    {
        foreach (int i in num) { Console.WriteLine(i); }
    }
} */

/**The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. So
the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
number: 2 + 3 = 5.This keeps going forever. */
//using System;
//namespace Assignment3;
//public class Assignment3Q2
//{
// 2 methods to get fib Nth number
/**public static void Main(String[] args)
{
    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Fibonacci(num);
    Console.WriteLine(Fibonacci(num));
}
public static int Fibonacci(int num)
{
    int n = num - 1;
    int[] Fib = new int[n+1];
    Fib[0] = 0; Fib[1] = 1;
    for (int i = 2; i <= n; i++)
    {
        Fib[i] = Fib[i - 2] + Fib[i - 1];
    }
    return Fib[n];
}*/

//1 method to get Fib Nth number
//    public static void Main(String[] args)
//    {
//        int[] Fib = new int[10]; Fib[0] = 0; Fib[1] = 1; 
//        int a = 0, b = 1, c = 0;
//        for (int i = 2; i < Fib.Length; i++)
//        {
//            c = a + b;
//            Fib[i] = c;
//            a = b;
//            b = c;

//        }
//        Console.WriteLine("Enter a number: ");
//        int num = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine(Fib[num]);
//    }
//}
