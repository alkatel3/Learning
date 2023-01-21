using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Input N");
                var n = Console.ReadLine();
                Console.Clear();
                if (Int32.TryParse(n, out int N) && N > 0)
                {
                    int[] number = new int[N];
                    for (int i = 0; i < number.Length; i++)
                    {
                        for (; ; )
                        {
                            Console.WriteLine($"Input {i + 1} element (type int and [-50;50])");
                            var element1 = Console.ReadLine();
                            if (Int32.TryParse(element1, out number[i]) && -50 <= number[i] && number[i] <= 50)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Element mast to have type int and to be [-50;50]");
                                continue;
                            }
                        }
                    }
                    int j = 1;
                    int element = number[0];
                    for (int i = 1; i < number.Length; i++)
                    {
                        if (element < number[i])
                        {
                            element = number[i];
                        }
                        else if (element == number[i])
                        {
                            j++;
                        }
                    }
                    Console.WriteLine($"Max is {element} and it is {j}");
                    Console.ReadKey();
                    Console.Clear();
                }
            } 
        }
    }
}
