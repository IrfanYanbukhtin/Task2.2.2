using System;

namespace Task2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeroCount = 0;
            int tmp = n;
            while (tmp != 0)
            {
                if (tmp % 10 == 0) 
                    zeroCount++;
                tmp /= 10;
            }
            Console.WriteLine($"{n}-deki sifirlarin sayi = {zeroCount}");
        }
    }
}
