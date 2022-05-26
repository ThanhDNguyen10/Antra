﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/**
1. What type would you choose for the following “numbers”?
A person’s telephone number - number
A person’s height - number
A person’s age - number
A person’s gender (Male, Female, Prefer Not To Answer)
A person’s salary - number
A book’s ISBN - number
A book’s price - number
A book’s shipping weight - number
A country’s population - number
The number of stars in the universe - number
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business) - number
2. What are the difference between value type and reference type variables? What is
boxing and unboxing? 
    1) value type will directly hold the value, while reference type will hold the memory address or reference for this value
    2) value type are stored in stack memory, while reference types will be stored in heap memory
    3) value type will not be collected by garbage collector, while reference type will be collected by garbage collector
    4) value type can be created by Struct or Enum, but reference type can be created by class, interface, delegate, or array
    5) value type cannot accept null values, but reference types can accept null values
    boxing: convert a value type to a reference type
    int i = 10;
    object o = i; //boxing
    int j = (int) o; //unboxing
    unboxing: convert the reference type to a value type
3. What is meant by the terms managed resource and unmanaged resource in .NET?
Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control.
Unmanaged resources are those that are not. File handles, pinned memory, COM objects, database connections etc.
4. Whats the purpose of Garbage Collector in .NET?
The garbage collector manages the allocation and release of memory for an application. For developers working with managed code, 
this means that you don't have to write code to perform memory management tasks. Automatic memory management can eliminate common problems, 
such as forgetting to free an object and causing a memory leak or attempting to access memory for an object that's already been freed.
 */
String name = "";
Console.WriteLine("Enter name: ");
name = Console.ReadLine();
Console.WriteLine(name);