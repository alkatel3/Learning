using Fitness.BL.Controller;
using Fitness.BL.Model;
using System.Globalization;
using System.Resources;

namespace Fitness.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.CreateSpecificCulture("ua-ua");
            var resourceManager=new ResourceManager("Fitness.CMD.Languages.Messages",typeof(Program).Assembly);
            Console.WriteLine(resourceManager.GetString("Hello",culture));
            Console.WriteLine(resourceManager.GetString("EnterName",culture));

            var name = Console.ReadLine();

            var userController = new UserController(name);
            var eatingController =new EatingController(userController.CurrentUser);

            if (userController.IsNewUser)
            {
                Console.Write("Write gender: ");
                var gender = Console.ReadLine();
                DateTime birthDate = ParseDatatime();;
                double weight = ParseDouble("weight");
                double height = ParseDouble("height");

                userController.SetNewUserData(gender, birthDate, weight, height);
            }


            Console.WriteLine(userController.CurrentUser);

            Console.WriteLine("What do you want do?");
            Console.WriteLine("E - enter getting foods");
            var key=Console.ReadKey();
            Console.WriteLine();
            if (key.Key == ConsoleKey.E)
            {
                var foods=EnterEating();
                eatingController.Add(foods.Food, foods.weight);

                foreach(var item in eatingController.Eating.Foods)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value}");
                }
            }
            Console.ReadLine();
        }

        private static (Food Food, double weight) EnterEating()
        {
            Console.Write("Write name of product: ");
            var food = Console.ReadLine();

            var weight = ParseDouble("weight of portion");
            var Proteins = ParseDouble("Proteins");
            var Fats = ParseDouble("Fats");
            var Carbohydrates = ParseDouble("Carbohydrates");
            var Calories = ParseDouble("Calories");

            var product = new Food(food, Proteins, Fats, Carbohydrates, Calories);
                
            return (product,weight);

        }

        private static DateTime ParseDatatime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Write date of birth (dd.MM.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorect format of date");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.Write($"Write {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Incorect format {name}");
                }
            }
        }
    }
}