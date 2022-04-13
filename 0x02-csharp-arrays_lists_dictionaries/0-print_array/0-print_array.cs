using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] numbers = new int[size];
        int index;

        for (index = 0; index <= numbers.Length; index++)
        {
            if (index + 1 <= numbers.Length)
            {
                numbers[index] = index;
                Console.Write(numbers[index]);
            }
            if (index + 1 == numbers.Length || index == numbers.Length)
            {
                Console.WriteLine();
                break;
            }            
            Console.Write(" ");
        }

        return numbers;
    }
}
