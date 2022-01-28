using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (statement 1; statement 2; statement 3) 
            {
              // code block to be executed
            }
            statement 1 - се изпълнява (еднократно) преди изпълнението на кодовия блок.
            statement 2 - определя условието за изпълнение на кодовия блок.
            statement 3 - се изпълнява (всеки път) след изпълнението на кодовия блок.*/
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int a = 1; a <= 11; a = a + 2)
            {
                Console.WriteLine(a);
            }
            /*foreach (type variableName in arrayName) 
              {
            // code block to be executed
              }*/
            string[] cars = { "Opel ", "Astra ","Siat ", "Tesla "};
            foreach(string showcars in cars)
            {
                Console.Write(showcars);
            }
                Console.ReadLine();
        }
    }
}
