using System;


namespace Project1
{
    public class Stack
    {
        private char[] stck;
        private int top;
        public Stack(int size)
        {
            stck = new char[size];
            top = 0;
        }
        public void Push(char ch)
        {
            if (top == stck.Length)
            {
                Console.WriteLine("- Стек заповнено");
                return;
            }
            stck[top] = ch;
            top++;
        }
        public char Pop()
        {
            if (top == 0)
            {
                Console.WriteLine("-Стек пустий");
                return (char)0;
            }
            top--;
            return stck[top];
        }
        public bool IsFull()
        {
            return top == stck.Length;
        }
        public bool IsEmpty()
        {
            return top == 0;
        }
        public int Capacity()
        {
            return stck.Length;
        }
        public int GetNum()
        {
            return top;
        }
    }
    class Example
    {
        static void Main(string[] args)
        {
            var shapes = new TwoDShape[4];

            shapes[0] = new Triangle(8.0, 12.0, "прямокутний");
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);
            //shapes[4] = new TwoDShape(10, 20, "загальна форма");

            for (int i=0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Об'єкт - {shapes[i].name} ");
                Console.WriteLine("Площадь равна " + shapes[i].Area());
                Console.WriteLine();
            }
        }
    } 
}
