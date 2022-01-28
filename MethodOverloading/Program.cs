using System;

namespace MethodOverloading
{
    class Program
    {
        static int MethodOverload(int x,int y, int z)
        {
            return x + y + z;
        }
          static int MethodOverload(int x,int y)
            {
           return y + x;
            }
        static double MethodOverload(double x,double y)
        {
            return y * x;
        }
    static void Main(string[] args)       // Instead of defining two methods that should do the same thing, it is better to overload one.
                                          //In the example below, we overload the PlusMethod method to work for both int and double: 
        {
            int num1 = MethodOverload(5,6); 
            double num2 = MethodOverload(5.5,6.2);    
            int num3 = MethodOverload(20, 35, 41);
            Console.WriteLine($"{num1}: Int");
            Console.WriteLine($"{num2}: double");
            Console.WriteLine($"{num3}: 3Numbers");
            Console.ReadLine();
            //Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.





        }
    }
}
