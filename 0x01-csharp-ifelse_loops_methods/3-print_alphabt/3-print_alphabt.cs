using System;
class Program
{
    static void Main(string[] args)
    {
        int abc;

        for (abc = 97; abc <= 122; abc++)
        {
            if (abc == 101 || abc == 113)
                continue;
            Console.Write((char) abc);
        }
    }
}