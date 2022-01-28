using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvance
{
    class Car
    {
        public string Color = "Blue";
        public string Model;
        public int Year;
        public int Speed;
        public Car(string ModelName) // how many parameters you want,Tip: Just like other methods, constructors can be overloaded by using different numbers of parameters.
        {
            //Model = "MUSTANG"; OR
            Model = ModelName;
        }
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        
        
    }
}
