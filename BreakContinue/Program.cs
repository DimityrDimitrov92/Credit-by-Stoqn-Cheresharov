using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 5; a <= 15; a++)
            {
                if (a == 9 || a == 13)
                {
                    continue;
                }
                Console.WriteLine(a);
            }
            for (int b = 3; b <= 9; b++)
            {
                if (b == 7)
                {
                    break;
                }
                Console.WriteLine(b);
            }
            int c = 0;
            while (c < 5)
            {
                Console.WriteLine(c);
                c++;
                if (c == 3)
                {
                    break;
                }
            }
            int d = 15;
            while (d < 35)
            {
                d++;
                if (d == 20)
                {
                    continue;
                }
                Console.WriteLine(d);
            }
            /*int i = 0;
            while (i < 10) 
             {
               if (i == 4) 
                {
                  i++;
                   continue;
                }
              Console.WriteLine(i);
              i++; 
             }*/


            Console.ReadLine();
        }
    }
}
