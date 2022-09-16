using MyStack_2.Model;

namespace MyStack_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Stack = new HardStack<int>();
            if (!Stack.IsEmpty)
            {
                Stack.Pop();
                Stack.Peak();
            }
            for(int i = 0; i < 10; i++)
            {
                Stack.Push(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Stack.Pop());
            }

        }
    }
}