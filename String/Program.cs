using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "Tova e prosto text";
            Console.WriteLine($"This contain {Text.Length} symbols");
            Console.WriteLine($"This put LowerCase : {Text.ToLower()}");
            Console.WriteLine($"This put LowerCase : {Text.ToUpper()}");


            string FirstName = "Dimityr ";
            string LastName = "Dilmarita :P";
            string Name = FirstName + LastName;
            //Console.WriteLine($"This is (Sbor ot dve promenlivi) \n First name : {FirstName}\n  Last name : {LastName} ");
            Console.WriteLine(Name); //concatenation
            string firstname = "Dimityr ";
            string lastname = "Dilmarita";
            string SecondName = "DimiLove ";
            string name = string.Concat(firstname, SecondName, lastname); //метода за обединяване на  string
            Console.WriteLine(name);

            /* string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
            Console.WriteLine(name);  string interpolation*/
            string MyString = "Dilmara";
            Console.WriteLine(MyString[1]);
            Console.WriteLine(MyString.IndexOf("m"));
            Console.WriteLine(MyString.IndexOf("f")); // not exist
                                                      // Full name
            string nameindex = "John Doe v";

            // Location of the letter n
            int charPos = nameindex.IndexOf("n");

            // Get last name
            string lastName1 = nameindex.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName1);
            Console.WriteLine(" \' \" \\");
            /*  \n	New Line	
                \t	Tab	
                \b	Backspace */


            Console.ReadLine();

        }
    }
}
