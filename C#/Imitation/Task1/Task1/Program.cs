/*Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
  Разработать классы-наследники: Треугольник, Квадрат, 
  Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг, 
  Эллипс. Реализовать конструкторы, которые однозначно 
  определяют объекты данных классов.
  Реализовать класс «Составная Фигура», который 
  может состоять из любого количества «Геометрических 
  Фигур». Для данного класса определить метод нахождения 
  площади фигуры. Создать диаграмму взаимоотношений 
  классов.*/
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle(4);
            var e = new Ellipse(2, -4);
            var p = new Parallelogram(1, 2, 30);
            Figure[] figures =
            {
                c,
                e,
                p,
                new Rectangle(3,7),
                new Rhombus(4,30),
                new Square(8),
                new Trapezoidal(10,24,15,13),
                new Triangle(4,7,30),
            };
            CombinationFigures combinationFigures = new(figures);
            foreach(var item in figures)
            {
                Console.WriteLine($"{item.Perimeter()}");
                Console.WriteLine($"{item.Square()}");
                Console.WriteLine();
            }
            Console.WriteLine(combinationFigures.Square());
        }
    }
}
