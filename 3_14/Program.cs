using System;

namespace _3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]num = {1,2,3,4,5 };
            string[] name = {"Jack","Mary","Tom","Grace","Alice" };
            int[] score1 = {80,65,100,98,83 };
            int[] score2 = { 75, 67, 93, 25, 82 };
            int[] score3 = { 60, 62, 91, 50, 87 };
            Console.WriteLine("請輸入座號:");
            string input = Console.ReadLine();
            int num1 = int.Parse(input);
            num1 = num1 - 1;
            int arrindex = Array.IndexOf(num,num1);
            if(num1>=0&&num1<=5)
            {
                Console.WriteLine("姓名:"+name[num1]);
                Console.WriteLine("電腦概論:" + score1[num1]);
                Console.WriteLine("程式設計:" + score2[num1]);
                Console.WriteLine("動畫設計:" + score3[num1]);
            }
            else 
            {
                Console.WriteLine("座號超出範圍");
            }
            Console.Read();
    


        }
    }
}
