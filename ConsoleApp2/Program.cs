using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();   // pravi konzolata 4ervena
            /*uint blq = uint.MaxValue;
            Console.WriteLine(blq+4);
            Decimal guru = Decimal.MaxValue;
            Console.WriteLine(guru);*/
            string name = "Gosho";
            int age = 45;
            Console.WriteLine($"My name is {name} i am {43} i {age}");
            DateTime d = new DateTime(2021, 12, 21, 13, 56, 24);
            Console.WriteLine("{0:Y}", d);   // :y,Y  t,T  d,D
            //Custom:
            Console.WriteLine("{0:dd-M-yy HH:mm:ss}", d);      //d, dd, M, MM, yy, yyyy, hh, HH, m, mm, s, ss 
            Console.WriteLine("{0:dd*MM/yyyy HH:mm:ss}", d);
            Console.WriteLine($"{d:dddd.MM.yyyy г.}");
            Console.Clear();
            Thread.CurrentThread.CurrentCulture =
            CultureInfo.GetCultureInfo("bg-Bg");
            Console.WriteLine("| {0,10:C} |", 120000.4532);
            Console.SetCursorPosition(30, 7);
            Console.WriteLine("| {0,10:C} |", 120000.4532);
            Console.SetCursorPosition(25, 0);   // Horizontal,VErtikal
            Console.ForegroundColor = ConsoleColor.Green;   // cveta na bukvite
            Console.WriteLine("| {0,10:C5} |", 120000.4532);
            Console.WriteLine("| {0,10:C4} |", 120000.4532);
            Console.BackgroundColor = ConsoleColor.White; // background na bukvite
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("| {0,10:C3} |", 120000.4532);
            Console.ForegroundColor = ConsoleColor.Black;
         //   Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write($"PLease enter something");
            int myChar = Console.Read();
            Console.WriteLine($"{(char)myChar}");
            /* Console.WriteLine("Please press ESC key to exit this endless loop");
             ConsoleKeyInfo cki;
             do {              
                 if (!Console.KeyAvailable)
                 {
                     Console.Clear();
                     Console.WriteLine("Please hit Esc");
                 }
                 cki = Console.ReadKey(true);
                 System.Threading.Thread.Sleep(50);
             } while(cki.Key != ConsoleKey.Escape);*/
            int age1 = 0;
            Console.Write($"vyvedi vyzrast");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{age1} , sled 10 godini ti 6te bydesh na {age1 + 10}");
        }
    }
}
