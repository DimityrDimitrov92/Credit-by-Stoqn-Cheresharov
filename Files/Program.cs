using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string WriteText = "DIlmara I LOve You !!! ";
            File.WriteAllText("Dilmara.txt",WriteText); //syzdava file with name filename.txt(format)

            string ReadText = File.ReadAllText("Dilmara.txt"); // 4ete ve4e syzdadeniq file
            Console.WriteLine(ReadText);

            
        }
    }
}
