﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> divList = new List<int>();
        int divNum = 0;

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                divNum = list1[i] / list2[i];
                divList.Add(divNum);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                divList.Add(0);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                break;
            }
        }

        return divList;
    }
}
