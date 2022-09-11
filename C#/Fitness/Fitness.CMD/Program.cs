using Fitness.BL.Controller;

namespace Fitness.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from app \"Fitnes\"");
            Console.WriteLine("Input name of user");

            var name = Console.ReadLine();

            Console.WriteLine("Input name of Gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Input birthday");
            var birthday = DateTime.Parse(Console.ReadLine());  // TODO rewrite to TryParse

            Console.WriteLine("Input weight");
            var weight =double.Parse( Console.ReadLine());

            Console.WriteLine("Input height");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthday, weight, height);
            userController.Save();
        }
    }
}