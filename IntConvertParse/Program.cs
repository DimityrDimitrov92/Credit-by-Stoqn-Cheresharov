using System;

namespace IntConvertParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int age1 = 0;
            Console.Write($"vyvedi vyzrast ");
            //  age1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{age1} , sled 10 godini ti 6te bydesh na {age1 + 10}");
            bool IsNumber = true;
            do
            {
                Console.Write("Enter your age:");
                IsNumber = int.TryParse(Console.ReadLine(), out age1);
            } while (!IsNumber);
            Console.WriteLine(IsNumber);
            int secondNumber = 33;
            int firstNumber = 3;
            if (secondNumber > firstNumber)
            {
                // int biggerNumber = secondNumber;
                Console.WriteLine(secondNumber);
            }
            Console.Write($"Enter your age");
        a: int myAge = int.Parse(Console.ReadLine());

            if (myAge < 3)
            {
                Console.WriteLine("You are a baby!");
            }
            else if (myAge >= 3 && myAge < 12)
            {
                Console.WriteLine("You are a kid!");
            }
            else if (12 <= myAge && myAge < 18)
            {
                Console.WriteLine("You are a teenager!");
            }
            else if (18 <= myAge && myAge < 30)
            {
                if (myAge == 27)
                {
                    Console.WriteLine("You are in your golden age and you are 27!");
                }
                else if (myAge == 28)
                {
                    Console.WriteLine("You are in your golden age and you are 28!");
                }
                else
                {
                    Console.WriteLine($"You are between 18 - 30");
                }
                Console.WriteLine($"You are in your gold years");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }
            goto a;

        }
    }
}
