using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> mulDict = new Dictionary<string, int>();;

        foreach (var (key, value) in myDict)
            mulDict.Add(key, (value * 2));

        return mulDict;
    }
}