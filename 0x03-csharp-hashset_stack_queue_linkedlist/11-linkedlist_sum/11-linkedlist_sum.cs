using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sumData = 0;

        foreach (int item in myLList)
            sumData += item;

        return sumData;
    }
}