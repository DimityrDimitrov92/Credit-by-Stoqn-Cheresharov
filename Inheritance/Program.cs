using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chief Saladd = new Chief();
            Saladd.MakeSalad();
            BGChief Musakata = new BGChief();
            Musakata.MakeBurger();
            Musakata.MakePishka();
            Musakata.MakeMusaka();
            Saladd.MakePishka();
            Car Car1 = new Car();
            Car1.Hong();
            Console.WriteLine($"{Car1.Brand}    {Car1.CarName}");

            Console.ReadLine();
        }
    }
}
