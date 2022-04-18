using System;
using System.Collections.Generic;

class MyQueue
{
public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {

        int numItems = aQueue.Count();
        Console.WriteLine("Number of items: {0}", numItems);

        // If queue is empty i cant iterate or search over it
        if (numItems == 0)
        {
            Console.WriteLine("Stack is empty");
            return aQueue;
        }

        else
        {
            string firstItem = aQueue.Peek();
            Console.WriteLine("Top item: {0}", firstItem);
        }

        bool findItem = aQueue.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, findItem);

        if (findItem)
        {
            while (aQueue.Contains(search) == true)
                aQueue.Dequeue();   
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}