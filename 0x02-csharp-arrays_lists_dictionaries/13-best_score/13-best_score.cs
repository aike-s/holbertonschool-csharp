using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxNum = 0;
        string name = "None";

        foreach (var (key, value) in myList)
        {
            if (maxNum <= value)
            {
                maxNum = value;
                name = (string) key;
            }
        }

        return name;
    }
}
