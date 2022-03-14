using System;

namespace _3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("請輸入N:");
            String input = Console.ReadLine();
            num = int.Parse(input);
            for (int i = 0; i < num; i++)
            {
                for (int i2 = 0; i2<= i; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
