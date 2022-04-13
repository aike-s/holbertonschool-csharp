using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> numbers = new List<int> ();
        int index;

        for (index = 0; index <= size; index++)
        {
            if (index + 1 <= size)
            {
                numbers.Add(index);
                Console.Write(numbers[index]);
            }
            if (index + 1 == size || index == size)
            {
                Console.WriteLine();
                break;
            }            
            Console.Write(" ");
        }

        return numbers;
    }
}