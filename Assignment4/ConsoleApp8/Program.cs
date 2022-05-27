// See https://aka.ms/new-console-template for more information
/**
1.Describe the problem generics address.
2. How would you create a list of strings, using the generic List class?
3.How many generic type parameters does the Dictionary class have?
4.True / False.When a generic class has multiple type parameters, they must all match.
5. What method is used to add items to a List object?
6. Name two methods that cause items to be removed from a List.
7. How do you indicate that a class has a generic type parameter?
8. True/False. Generic classes can only have one generic type parameter.
9. True/False. Generic type constraints limit what can be used for the generic type.
10. True/False. Constraints let you use the methods of the thing you are constraining to.
*/
/**1.Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
1. int Count()
2.T Pop()
3.Void Push() */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class MyStack<T> 
    {
        public int Count()
        { int x = 0;    return x; }
        public T Pop()
        {
            T x = Pop();
            return x;
        }
        public void Push() { }
    }
}
