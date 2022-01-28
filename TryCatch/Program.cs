using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] num = { 1, 4, 6 };
                Console.WriteLine(num[10]);
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            finally
            {
                Console.WriteLine($"finished");
            }
            
        }
    }
}
