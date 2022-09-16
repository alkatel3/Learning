using MyStack_3.Model;

namespace MyStack_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack=new ArrayStack<int>();
            if (!stack.IsEmpty)
            {
                stack.Pop();
                stack.Peak();
            }
            for(int i=0; i < 10; i++)
            {
                stack.Push(i);
                Console.WriteLine();
                Console.WriteLine($"Count: {stack.Count}");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stack.Pop());

                Console.WriteLine();
                Console.WriteLine($"Count: {stack.Count}");
            }
        }
    }
}