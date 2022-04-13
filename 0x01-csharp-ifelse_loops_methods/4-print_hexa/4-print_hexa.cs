using System;
class Program
{
    static void Main(string[] args)
    {
        int dec_num;

        for (dec_num = 0; dec_num <= 98; dec_num++)
        {
            string hex_num = dec_num.ToString("x");
            Console.WriteLine("{0} = 0x{1}", dec_num, hex_num);
        }
    }
}