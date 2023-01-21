using System;

namespace ExtensionMethods
{

    static class WxampleExtensions
    {
        public static int NumberWords(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return 0;
            }
            data = System.Text.RegularExpressions.Regex.Replace(data.Trim(), @"\s+", " ");

            return data.Split(' ').Length;
        }

        public static int Min(this int[] arr)
        {
            int min=arr[0];
            for(int i=0; i < arr.Length; i++)
            {
                min = min > arr[i] ? arr[i] : min;
            }
            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");

            string str = Console.ReadLine();

            Console.WriteLine($"The number of words in the string: {str.NumberWords()}");
            int[] arr ={ -100, 14, 123, 12 };
            Console.WriteLine(arr.Min());
        }
    }
}
