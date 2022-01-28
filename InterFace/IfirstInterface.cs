using System;
using System.Collections.Generic;
using System.Text;

namespace InterFace
{
    interface IFirstMethod
    {
        void Method();
    }
    interface ISecondMethod
    {
        void myOtherMethod();
    }
    interface ITriedMethod
    {
        void myTriedMethod();
    }
    class DemoClass : IFirstMethod, ISecondMethod
    {
        public void Method()
        {
            Console.WriteLine("Some text...");
        }
        public void myOtherMethod()
        {
            Console.WriteLine($"Some another text...");
        }
        public void myTriedMethod()
        {
            Console.WriteLine($"HUI");
        }
    }
}

