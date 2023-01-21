using static System.Console;
using static System.Math;
using static HelloApp.Geometry;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 50;
            double result = GetArea(radius); //Geometry.GetArea
            WriteLine(result); //Console.WriteLine
            Read(); // Console.Read
        }
    }

    class Geometry
    {
        public static double GetArea(double radius)
        {
            return PI * radius * radius; // Math.PI
        }
    }
}