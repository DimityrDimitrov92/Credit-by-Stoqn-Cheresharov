using MassTransit.Monitoring.Performance;
using System;

namespace OOPStoqn
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine($"cons PI {Person.PI}");

            Person person1 = new Person("Pencho", 59);
            // person1.Name = "Pencho";

            Person person2 = new Person();
            Person person3 = new Person("Stoqn", 54, 0, "Ivan", "Gosho", "Dragan");
            // Console.WriteLine(person2.Age);
            person1.IntroduceYourSelf();
            person2.IntroduceYourSelf();
            DoSomethingElse();
            Console.WriteLine($"The population of my little kingdom is {Person.Counter} ");
            DoSomethingElse();
            Console.WriteLine($"the first friend of Stoqn is {person3[2]} ");
            Console.WriteLine($"Person 3 has {person3[1]}");
            //person3.only4read = 1000; // ne moje 
            Console.WriteLine($"only for read {Person.only4read}");
            Console.WriteLine($"RazgeLEEE {Person.Neshto()}");
        }
        static void DoSomethingElse()
        {
            Person gabi = new Person("Gabi", 18);

        }
       
    }

}
