using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        // If the LList is empty it will not enter here
        foreach (int value in myLList)
        {
            if (n <= value)
            {
                LinkedListNode<int> addNode = myLList.Find(value);
                myLList.AddBefore(addNode, n);
                return myLList.Find(n);
            }
        }

        // If the LList is empty the first element will be the new element
        myLList.AddLast(newNode);

        return newNode;
    }
}