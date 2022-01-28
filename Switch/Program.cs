using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*switch (expression)
             {
                case x:
                     // code block
                     break;
                 case y:
                     // code block
                     break;
                 default:
                     // code block
                     break;

             }*/

            int day = 2;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Another day");
                    break;
            }
            Console.ReadLine();
        }
    }
}
