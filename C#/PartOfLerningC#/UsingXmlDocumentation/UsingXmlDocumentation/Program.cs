namespace UsingXmlDocumentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of kilometers: ");
                double distance=double.Parse(Console.ReadLine());
                Console.WriteLine($"\n{distance} kilometers is {Distance.KilometersToMiles(distance)} miles.\n");

                Console.Write("Enter the number of miles: ");
                distance = double.Parse(Console.ReadLine());
                Console.WriteLine($"\n{distance} miles is {Distance.MilesToKilometers(distance)} kilometers.\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}