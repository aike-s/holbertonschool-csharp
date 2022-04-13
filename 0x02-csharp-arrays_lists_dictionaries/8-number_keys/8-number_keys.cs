using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int numKeys = 0;

        foreach (KeyValuePair<string, string> pair in myDict)
            numKeys++;

        return numKeys;        
    }
}