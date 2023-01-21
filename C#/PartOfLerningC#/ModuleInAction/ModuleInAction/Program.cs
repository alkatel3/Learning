using System.Reflection;

namespace ModuleInAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName("SimpleLibrary.dll"));

            Module? mod = assembly.GetModule("SimpleLibrary.dll");

            Console.WriteLine("Declared data types:");
            foreach (Type t in mod.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }
            Type Person = mod.GetType("SimpleLibrary.Person") as Type;

            object person = Activator.CreateInstance(Person, new object[] {"Oleg", "Yovic", 19});
            Person.GetMethod("Print").Invoke(person, null);

        }
    }
}