using System;

namespace DilmaraBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name;
           int age = 0;


            Console.Write($"        Put your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"            Hello {name} , Welcome on the Dimitar platform :)");
            do
            {
                Console.Write($"        Please {name} , Put now your age : ");
                 age = int.Parse(Console.ReadLine());
            } while (age<0 || age >100);
            
          //  int age;
            //bool resultBool = int.TryParse(Console.ReadLine(),out age);
            //if (age < 5 && age > 100) ;
            //{
            //    resultBool = false;
            //}
            Console.WriteLine($"            Great {name} you are {age} years old ");
            Console.Write($"        Great , Now is  time to write your kg. : ");
            double kg = int.Parse(Console.ReadLine());
            Console.Write($"        Now put your tall : ");
            double tall = double.Parse(Console.ReadLine());
            //BMI = kg/m2
            double result = kg / (tall * tall);
            Console.WriteLine($"Your BMI = {result:0.00}");
            if (result < 16)
            {
                Console.WriteLine($" Your category is : Severe Thinness ");
            }
            else if (result < 17)
            {
                Console.WriteLine($" Your category is : Moderate Thinness ");
            }
            else if (result < 18.5)
            {
                Console.WriteLine($" Your category is : Mild Thinness ");
            }
            else if (result < 25)
            {
                Console.WriteLine($" Your category is : Normal ");
            }
            else if (result < 30)
            {
                Console.WriteLine($" Your category is : Overweight ");
            }
            else if (result < 35)
            {
                Console.WriteLine($" Your category is : Obese Class I ");
            }
            else if (result < 40)
            {
                Console.WriteLine($"Your category is : Obese Class II ");
            }
            else if (result >= 40)
            {
                Console.WriteLine($"Your category is : Obese Class III ");
            }
            Console.ReadLine();


        }

    }
}

