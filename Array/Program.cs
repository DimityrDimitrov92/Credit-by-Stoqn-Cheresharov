using System;
using System.Linq; // New using !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

namespace Array1
{
    class Program
    {

        static void Main(string[] args)
        {
            //string[] cars;
            string[] cars = { "BMV", "TOYOTA", "Mercedes", "Golf", "Mazda", "Ford" };
            int[] Num = { 4, 7, 2, 34 };


            Console.WriteLine(cars[1]);
            cars[1] = "TRABANT";
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars.Length);
            for (int a = 1; a < cars.Length; a++)
            {
                Console.WriteLine(cars[a]);
            }
            foreach (int showN in Num)
            {
                Console.WriteLine(showN);
            }
            /*      foreach (type variableName in arrayName) 
             {
            // code block to be executed
             }*/
            Array.Sort(cars);
            Array.Sort(Num);

            foreach (string showcars in cars)
            {
                Console.WriteLine(showcars);
            }
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
                                                 // Create an array of four elements, and add values later
            /* string[] cars = new string[4];

              // Create an array of four elements and add values right away 
             string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

             // Create an array of four elements without specifying the size 
             string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

             // Create an array of four elements, omitting the new keyword, and without specifying the size
             string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };       OTHER WAYS TO CREATE ARRAY !!!    

            // Declare an array
             string[] cars;

             // Add values, using new
             cars = new string[] {"Volvo", "BMW", "Ford"};

            // Add values without using new (this will cause an error)
            cars = {"Volvo", "BMW", "Ford"};
            */


            Console.ReadLine();
        }
    }
}
