using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> firstLL = new LinkedList<int>();

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
                firstLL.AddLast(i);

            foreach (int item in firstLL)
                Console.WriteLine(item);
        }

        return firstLL;
    }
}