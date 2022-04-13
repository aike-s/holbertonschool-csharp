using System;
class Program
{
    static void Main(string[] args)
    {
        int num;
        for (num = 1; num <= 100; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
                Console.Write("FizzBuzz");
            else if (num % 3 == 0)
                Console.Write("Fizz");
            else if (num % 5 == 0)
                Console.Write("Buzz");
            else if (num < 100)
                Console.Write("{0}", num);
            if (num < 100)
                Console.Write(" ");
            if (num == 100)
                Console.Write("\n");
        }
    }
}