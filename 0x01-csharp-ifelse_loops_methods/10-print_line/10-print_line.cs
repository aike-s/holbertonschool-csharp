using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (!(length <= 0))
            while (length >= 1)
            {
                Console.Write("_");
                length--;
            }
            
        Console.Write("\n");
    }
}