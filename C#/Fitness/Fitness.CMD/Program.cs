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
            var eatingController = new EatingController(userController.CurrentUser);
            var exerciseController = new ExerciseController(userController.CurrentUser);

            if (userController.IsNewUser)
            {
                Console.Write("Write gender: ");
                var gender = Console.ReadLine();
                DateTime birthDate = ParseDatatime("date of birth");;
                double weight = ParseDouble("weight");
                double height = ParseDouble("height");

                userController.SetNewUserData(gender, birthDate, weight, height);
            }


            Console.WriteLine(userController.CurrentUser);
            while (true)
            {
                Console.WriteLine("What do you want do?");
                Console.WriteLine("E - enter getting foods");
                Console.WriteLine("A - enter exercise");
                Console.WriteLine("Q - exit");
                var key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.E:
                        var foods = EnterEating();
                        eatingController.Add(foods.Food, foods.weight);

                        foreach (var item in eatingController.Eating.Foods)
                        {
                            Console.WriteLine($"\t{item.Key} - {item.Value}");
                        }
                        break;
                    case ConsoleKey.A:
                        var exe = EnterExercise();

                        exerciseController.Add(exe.activity, exe.start, exe.finish);

                        foreach(var item in exerciseController.Exercises)
                        {
                            Console.WriteLine($"{item.Activity} from {item.Start.ToShortTimeString()} to {item.Finish.ToShortTimeString()}");
                        }
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;

                }
                Console.ReadLine();
            }
   
        }

        private static (DateTime start, DateTime finish, Activity activity) EnterExercise()
        {
            Console.WriteLine("Enter name of exercise");
            var name = Console.ReadLine();

            var energy = ParseDouble("energy"); 

            var begin = ParseDatatime("start of exercise");
            var end = ParseDatatime("finish of exercise");

            var activity = new Activity(name, energy);
            return (begin, end, activity);
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

        private static DateTime ParseDatatime(string value)
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write($"Write {value} (dd.MM.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorect format of value");
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