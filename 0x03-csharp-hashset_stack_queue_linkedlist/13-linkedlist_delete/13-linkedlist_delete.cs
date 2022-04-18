using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int findIndex = 0;

        foreach (int value in myLList)
        {
            if (findIndex == index)
            {
                myLList.Remove(value);
                return;
            }
            findIndex++;
        }
    }
}