using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int index;
        int space;

        if (!(length <= 0))
            for (index = 1; index <= length; index++)
            {
                space = index - 1;
                while (space > 0)
                {
                    Console.Write(" ");
                    space--;
                }
                Console.WriteLine("\\");
            }
            
        Console.Write("\n");
    }
}