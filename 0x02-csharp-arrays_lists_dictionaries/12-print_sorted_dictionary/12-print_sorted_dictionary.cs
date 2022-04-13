using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> orderedKeys = new List<string> ();

        foreach (string key in myDict.Keys)
            orderedKeys.Add(key);

        orderedKeys.Sort();

        foreach (string key in orderedKeys)
            Console.WriteLine("{0}: {1}", key, myDict[key]);
    }
}
