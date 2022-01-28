using System;

namespace Facturiel
{
    class Program
    {
        private const int v = 34;
        private static int broqch;

        static void Main(string[] args)
        {
            Console.Write($"Въведете факториел : ");
            int n = int.Parse(Console.ReadLine());
            int fackt = 1;
            for (int i = 1; i <= n; i++)
            {
                fackt *= i;
            }
            Console.WriteLine($"{n}! = {fackt} ");
            
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Output: ");
            for (int index = 0; index < array.Length; index++)
            {
                // Doubling the number
                array[index] = 2 * array[index];
                // Print the number
                Console.Write(array[index] + " ");
            }
            foreach (int array1 in array)
            {
                Console.WriteLine(array1);
            }
            string[] cars = { "Toyota", "Mercedes", "Huindai" };
            foreach (string car1 in cars)
            {
                Console.WriteLine($"{car1}: ");
            }
            int[] MoreNum = { 2, 4, 5, 7, 8 };
            for (int broqch = 0; broqch < MoreNum.Length; broqch++)
            {
                MoreNum[broqch] = MoreNum[broqch] * 3;
                Console.WriteLine(MoreNum[broqch] + "");
            }
            int[,] gosho =
            {
                {4,5,6},               // Равномерни матрици
                {7,8,9},
            };
            Console.WriteLine(gosho[1, 2]);
            Console.WriteLine(gosho.GetLength(0));
            Console.WriteLine(gosho.GetLength(1));
          // Console.Clear();
            //int something = Sbor(454, 65) + 45;
            Console.WriteLine(Sbor(60, 6));
            Console.WriteLine(Sbor(6, 8));
            int something = Sbor(60, 6) / 10;
            Console.WriteLine(something);
            int[] array11 = { 4, 5, 6, 7, 8 };
            int[] array12 = { 21, 22, 23, 24 };
            ArrayPrint(array11);
            ArrayPrint(array12);
            //  Console.WriteLine(array11)
            VerablesParms("gosho", 2, 3, 4, 5, 6, 6, 6);
            Sbor(y: 3, x: 3, z: 5);
            Console.WriteLine(Sbor(y: 3, x: 3, z: 5));
            Console.Write($"text facturiel ");
            int FAct = int.Parse(Console.ReadLine());
            Console.WriteLine(Facturiel(FAct));
        }

        static int Sbor(int x, int z, int y = 5)
        {
            // Console.WriteLine(x + y);
            return x + y;
        }
        static void ArrayPrint(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void VerablesParms(string name, params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{name} {x[i]} = ");
            }
        }
        static int Facturiel(int n)
        {
            if (n == 0) return 1;
            return Facturiel(n - 1) * n;
        }
    }
}