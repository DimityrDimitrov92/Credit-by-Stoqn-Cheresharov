using System;

namespace AnotherMethodIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening."; //variable = (condition) ? expressionTrue :  expressionFalse;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
