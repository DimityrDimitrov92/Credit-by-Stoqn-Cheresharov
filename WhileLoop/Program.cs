using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (condition) 
           {
              // code block to be executed
           }*/
            int i = 0;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            /*do 
             {
             // code block to be executed
             }
             while (condition);*/
            i = 7;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
            
            
            
            Console.ReadLine();
        }
    }
}
