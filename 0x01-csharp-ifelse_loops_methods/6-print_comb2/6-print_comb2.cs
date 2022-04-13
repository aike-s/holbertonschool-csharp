using System;
class Program
{
    static void Main(string[] args)
    {
        int num;

        for (num = 0; num <= 99; num++)
        {
            int first = num / 10;
            int last = num % 10;

            if (num == 89)
                Console.Write("{0}\n", num);

            if (first < last)
                Console.Write("{0}, ", num.ToString("D2"));
        }
    }
}
