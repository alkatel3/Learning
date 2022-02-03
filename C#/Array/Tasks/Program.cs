using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            Task1();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task2();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task3();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task4();
            Console.WriteLine(new String('.', Console.BufferWidth));
        }
        static void Task1()
        {

            int[] array = CreatingArray(0, 30);
            Console.Write("Before: ");
            Show(array);
            int Length = array.Length;
            for(int i = 0; i < Length; i++)
            {
                if (array[i] == 0)
                {
                    for(int j = i; j < Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[Length - 1] = -1;
                }
            }
            Console.Write("After: ");
            Show(array);
        }
        static void Task2()
        {
            int CountNegative=0;
            int[] arr = CreatingArray(-5, 5);
            Console.Write("Before: ");
            Show(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    int num = arr[i];
                    for(int j = i; j > CountNegative; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[CountNegative] = num;
                    CountNegative++;
                }
            }
            Console.Write("After: ");
            Show(arr);
            
        }
        static void Task3()
        {
            int[] arr = CreatingArray(0, 15);
            Show(arr);
            Console.Write("Enter number from 0 to 15: ");
            int number = Int32.Parse(Console.ReadLine());
            int count = 0;

            foreach(var item in arr)
            {
                if (item == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Task4()
        {
            int[,] arr = CreatingArray2(0,10);
            Console.WriteLine("Before:");
            Show2(arr);
            int FirstColumn = 2, SecondColumn = 5; ;

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                int num = arr[i, FirstColumn];
                arr[i, FirstColumn] = arr[i, SecondColumn];
                arr[i, SecondColumn] = num;
            }
            Console.WriteLine("After:");
            Show2(arr);
        }
        static void Show(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        static int[] CreatingArray(int min, int max)
        {
            Console.Write("Enter size: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Random rnd = new();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
            return arr;
        }
        static int[,] CreatingArray2(int min, int max)
        {
            Console.Write("Enter count of line in array: ");
            int line = Int32.Parse(Console.ReadLine());
            Console.Write("Enter count of column in array: ");
            int column = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[line,column];
            Random rnd = new();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(min, max);
                }
            }
            return arr;
        }
        static void Show2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
