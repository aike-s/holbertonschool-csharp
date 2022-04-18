using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> uniqueValues = new List<int> ();

        foreach (int value in myList)
        {
            if (!uniqueValues.Contains(value))
                uniqueValues.Add(value);
        }

        int sumValues = 0;
        
        foreach (int value in uniqueValues)
            subValues += value;

        return sumValues;
    }
}
