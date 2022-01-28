using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
