using System;

namespace Methods
{
    class Program
    {
        static void ValuesInside(string One = "Ivan",string Two = "Georgi")
        {
            Console.WriteLine(Two);
        }
        static int ReturnXy(int x , int y)
        {
           return x * y;
        }
        static int ReturnInt(int x)
        {
            return 5 + x;
        }
        static void MyMethod (string Fname,int Age)
        {
            Console.WriteLine($"{Fname} Hello ,You are {Age} Years old");
        }
        static void Countries (string country = "Bulgaria")
        {
            Console.WriteLine($"I been in {country}");
        }
        static void Main(string[] args)
        {
            MyMethod("Dilmara ",29);
            MyMethod("Dimi ",28);
            Countries("Brazil");
            Countries("Italy");
            Countries("Mexico");
            Countries();
            Console.WriteLine(ReturnInt(5));
            Console.WriteLine(ReturnXy(6, 5)); // 6*5
            int a = ReturnXy(6, 5); // You can also store the result in a variable (recommended, as it is easier to read and maintain)
            MyMethod(Age: 25, Fname: "Pencho");//It is also possible to send arguments with the key: value syntax.(Могат да се сменят местата)
            ValuesInside();
            Console.WriteLine(a);
            Console.ReadLine();


        }
    }
}
