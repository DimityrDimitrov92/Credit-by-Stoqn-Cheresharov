using System;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] cities = new string[3];
            InputString(cities);

            SortString(cities);
            Console.WriteLine("---------------Sorted--------");
            OutputString(cities);
            Console.WriteLine($"--------Filtred------");
            OutputString(FilterString(cities, 'P'));


            int[] MaxNum = new int[20];
            // InputInt(MaxNum);
            SeedIntArray(MaxNum, 5, 800);
            OutPutInt(MaxNum);

            Console.WriteLine("Max value is {0}",MaxIntArray(MaxNum));
            Console.WriteLine("Max value is {0}",MinIntArray(MaxNum));
            

        }
        static void InputString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter city Name[{i + 1}] : ");
                array[i] = Console.ReadLine();
            }
        }
        static void SortString(string[] array)
        {
            string swap;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (string.Compare(array[i], array[j]) > 0)
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }
        static void OutputString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] = : {array[i]}");

            }
        }
        static string[] FilterString(string[] array, char FirstLetter)
        {
            string[] FiltredArray = new string[array.Length];
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i][0] == FirstLetter)
                {
                    FiltredArray[counter] = array[i];
                    counter++;
                }
            }
            return FiltredArray;
        }
        static void InputInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Please enter element {i + 1} : ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static void OutPutInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{array[i]}]  ");
            }
        }
        static int MaxIntArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }
        static int MinIntArray(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }
        static void SeedIntArray(int[] array, int min, int max)
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next(min, max);
            }
        }

    }
}
