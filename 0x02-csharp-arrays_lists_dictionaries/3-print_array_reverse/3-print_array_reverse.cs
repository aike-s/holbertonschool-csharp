
using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length < 0)
        {
            Console.WriteLine();
            return;
        }

        int index = array.Length - 1;

        for (; index >= 0; index--)
        {

            Console.Write(array[index]);
            if (index != 0)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}