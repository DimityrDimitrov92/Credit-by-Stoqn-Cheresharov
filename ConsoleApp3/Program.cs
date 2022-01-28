using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gosho =
       {
                {4,5,6},
                {7,8,9},
            };
            Console.WriteLine(gosho[1, 2]);
            Console.WriteLine(gosho.GetLength(0));
            Console.WriteLine(gosho.GetLength(1));
        }
    }
}
