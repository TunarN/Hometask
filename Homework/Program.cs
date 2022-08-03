using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int min = 5;
                for (int i = 0; i < num.Length; i++)
            {
                if (num[i]<min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
