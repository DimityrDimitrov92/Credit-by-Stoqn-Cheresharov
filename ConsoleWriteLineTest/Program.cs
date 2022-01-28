using System;

namespace ConsoleWriteLineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NAme :");
            string UserName = Console.ReadLine(); // Return only String
            Console.WriteLine($"User Name:  {UserName}" ); 
            
            Console.Write("Put Your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Age : {Age} ");
            Console.ReadLine();
            int x = 5;
            Console.WriteLine(!(x > 3 && x < 10));
        }
    }
}
