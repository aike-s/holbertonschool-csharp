using System;
class Program
{
    static void Main(string[] args)
    {
        int num;

        for (num = 0; num <= 99; num++)
        {
            if (num == 99)
            {
                Console.Write("{0}\n", num);
                break;
            }
            Console.Write("{0}, ", num.ToString("D2"));
        }
    }
}