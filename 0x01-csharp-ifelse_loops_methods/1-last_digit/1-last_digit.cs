using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last_num = (number % 10);
    
        if (last_num > 5)
            Console.WriteLine("The last digit of {0} is {1} and is greater than 5", number, last_num);
        else if (last_num == 0)
            Console.WriteLine("The last digit of {0} is {1} and is 0", number, last_num);
        else if (last_num < 6 && last_num != 0)
            Console.WriteLine("The last digit of {0} is {1} and is less than 6 and not 0", number, last_num);
    }
}