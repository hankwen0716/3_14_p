using System;

namespace _3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字:");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (num % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (num >= 2 && num <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (num >= 6 && num <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else
                {
                    Console.WriteLine("Not Weird");
                }
            }
            Console.WriteLine("按下任意按鈕結束程式");
            Console.Read();
        }
    }
}
