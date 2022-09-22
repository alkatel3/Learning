using System.Diagnostics;

namespace BinaryHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            var rnd = new Random();
            var startItems = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }
            timer.Start();
            var heap = new Heap<int>(startItems);
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Restart();
            for (int i = 0; i < 10000; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Restart();
            int j = 1;
            foreach (var item in heap)
            {
                Console.WriteLine($"{j}\t{item}");
                j++;
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
        }
    }
}