using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {

        int numItems = aStack.Count();
        Console.WriteLine("Number of items: {0}", numItems);

        // If stack is empty i cant iterate or search over it
        if (numItems == 0)
        {
            Console.WriteLine("Stack is empty");
            return aStack;
        }

        else
        {
            string firstItem = aStack.Peek();
            Console.WriteLine("Top item: {0}", firstItem);
        }

        bool findItem = aStack.Contains(search);

        if (findItem)
        {
            Console.WriteLine("Stack contains \"{0}\": True", search);
            while (aStack.Contains(search) == true)
                aStack.Pop();   
        }
        else
            Console.WriteLine("Stack contains \"{0}\": True", search);

        aStack.Push(newItem);

        return aStack;
    }
}