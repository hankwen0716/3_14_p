using System;

namespace _3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九乘法表練習");
            int num = 0;
           for(int i=1;i<=9;i++)
            {
                for(int j=1;j<=9;j++)
                {
                    num = i * j;
                    Console.Write(i+"*"+j+"="+num);
                    Console.Write(" ");

                    if(num<10)//排版用
                    { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("按下任意按鈕結束程式");
            Console.Read();
        }
    }
}
