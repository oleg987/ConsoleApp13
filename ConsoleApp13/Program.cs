using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            double y = 257.9;

            x = (int)y;

            y = x;
            // 
            Console.WriteLine(y);
        }
    }
}
