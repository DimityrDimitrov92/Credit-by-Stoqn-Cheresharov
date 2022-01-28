using System;

namespace OOP
{
    class Program
    {
        class Car
        {
            string color = "red";

            static void Main(string[] args)
            {
                Car MyObj = new Car();
                Console.WriteLine(MyObj.color);   // Class is : Fruits     Objects is : Apple ,Mango ,Banana ,Cheery
                Car MyObj1 = new Car();          //You can create multiple objects of one class:
                Console.WriteLine(MyObj1.color);
                Car1 MyobjClass = new Car1();
                Console.WriteLine(MyobjClass.Color1);/*Did you notice the public keyword(Page 2) ? It is called an access modifier, which specifies 
                                             * that the color variable/field of Car is accessible for other classes as well, such as Program.
                                                  You will learn much more about access modifiers and classes/objects in the next chapters.*/

            }
        }
    }
}
