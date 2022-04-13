using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> divisiblesOrNot = new List<bool> ();

        foreach (int num in myList)
        {
            if (num % 2 == 0)
                divisiblesOrNot.Add(true);
            else
                divisiblesOrNot.Add(false);
        }

        return divisiblesOrNot;
    }
}