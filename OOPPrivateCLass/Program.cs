using System;

namespace OOPPrivateCLass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myobj = new Person();
            myobj.Name = "DIl";
            Console.WriteLine(myobj.Name);
            Person myobj1 = new Person();
            myobj1.Name1 = "dil";
            Console.WriteLine(myobj1.Name1);
        }
    }
}
