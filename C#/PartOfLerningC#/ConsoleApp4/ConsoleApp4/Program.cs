using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            Console.WriteLine("Введiть 7 чисел");
            
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Ввeдiть {0}-те число:",i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int rang;
            for(int i=0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        rang = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = rang;
                    }
                }    
            }


            Console.WriteLine("вiдсортований массив");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
