using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStoqn
{
    class Person
    {
        private string name;
        private int age;
        private double temp; // bez properti
        private decimal balance;
        private string[] friends;
        private static int counter = 0;// скъсахме 'етикетчето'
        public const double PI = 3.14;
        public static readonly double only4read = 2.71;
        public static int Counter
        {
            get { return counter; }
            // set { counter = value; }
        }
        
        public string this[int i]
        {
            get { return friends[i]; } // inishalqizer ,otiva do kolekcii
            set { friends[i] = value; }// moje da ima samo edin
        }
        public string Name // Properti
        {
            get { return name; }
            set { name = value; }
        }
        public int Age // Properti
        {
            get { return age; }
            set { age = value; }
        }

       

        public double Balance // bez pole ,
        {
            get { return 3.14 * age; }// samo chete
        }
        public Person()
            : this("Default", 0)
        {
            // this.name = "Defaut";
            //this.age = 0;
        }
        //working hourse
        public Person(string name, int age, decimal balance = 0.0M, params string[] friends) // Konstruktor, nqma vyrnata stoinost (move da prieme stoinost moje i ne)
        {
            
            this.name = name;
            this.age = age;
            this.balance = balance;
            this.friends = friends;
            counter++;
            // only4read = age * 25; ne moje za6toto e static

            //Age = age;
            //Name = name;
        }
        static Person()
        {
            only4read = 545;
        }

        public Person(int age, string name)
            : this(name, age)
        {
            //this.name = name;
            // this.age = age;
        }
        public void IntroduceYourSelf()//Method
        {
            Console.WriteLine($"Hello my name is {name} and i am {age} year old !");
        }
        public static double Neshto()
        {
            return counter * 1000;
        }
        
    }
}