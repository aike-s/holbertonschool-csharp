using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int maxNum = myList[0];

        foreach (int num in myList)
            if (maxNum < num)
                maxNum = num;

        return maxNum;
    }
}
