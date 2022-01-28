using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Level myVar = Level.middle;
            Console.WriteLine(myVar);
            int Mynum = (int)Level.hihg; // Convert to show the number of enum (start from 0)
            Console.WriteLine(Mynum);
            Level myVar2 = Level.hihg;
            switch(myVar2)
            {
                case Level.Low:
                    Console.WriteLine($"LOw LEVEL");//Защо и кога да използваме Enum?
                   // Използвайте изброявания, когато имате стойности, които знаете, че няма да се променят, като например месечни дни, дни, цветове, тесте карти и т.н.
                    break;
                case Level.middle:
                    Console.WriteLine($"middle Level");
                    break;
                case Level.hihg:
                    Console.WriteLine($"High LEvel");
                    break;
                default:
                    Console.WriteLine($"ne znam kakvo 6te stane");
                    break;


            }

            Console.ReadLine();
        }
    }
}
