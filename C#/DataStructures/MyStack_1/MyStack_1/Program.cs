using MyStack_1.Model;

namespace MyStack_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new EasyStack<int>();
            if (!stack.IsEmpty)
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Peak());
            }
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            if (!stack.IsEmpty)
            {
                Console.WriteLine(stack.Peak());
            }
        }
    }
}