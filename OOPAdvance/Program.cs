using System;

namespace OOPAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car Volvo = new Car("Pejo"); //Note that the constructor name must match the class name, and it cannot have a return type (like void or int).
            Volvo.Model = "Volvo"; //Also note that the constructor is called when the object is created.
            Volvo.Year = 1994; //All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you
            Volvo.Speed = 200;//are not able to set initial values for fields.
            Console.WriteLine(Volvo.Color);
            Console.WriteLine($"{Volvo.Model} have {Volvo.Color} color and can reach {Volvo.Speed}/h.");
            Console.WriteLine(Volvo.Year);
            Console.WriteLine(Volvo.Speed);// Save time with Constructor !!!
            Volvo.fullThrottle();
            Car Ford = new Car("Mustangfgdfg");
            Console.WriteLine(Ford.Model);
            Console.ReadLine();
        }
    }
}
