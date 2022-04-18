using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonValues = new List<int> ();
        
        foreach (int value in list1)
        {
            if (list2.Contains(value))
                commonValues.Add(value);
        }

        commonValues.Sort();   
        return commonValues;
    }
}