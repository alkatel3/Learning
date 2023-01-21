using AssemblyExample;
using System.Reflection;
using static System.Console;

namespace UseExtensionBuilds

{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Path.GetDirectoryName(Assembly.
                GetEntryAssembly().Location);
                List<Type> list = new List<Type>();
                foreach (string s in Directory.GetFiles(path,
                "*.dll"))
                {
                    Assembly a = Assembly.LoadFrom(s);
                    foreach (Type t in a.GetExportedTypes())
                    {
                        if (!t.IsClass |
                        !typeof(IAssemblyExample).
                        IsAssignableFrom(t))
                        {
                            continue;
                        }
                        list.Add(t);
                    }
                }
                Write("Enter the number: ");
                int number = int.Parse(ReadLine());
                // вызов метода интерфейса для всех 
                // найденных типов
                foreach (Type t in list)
                {
                    WriteLine((Activator.CreateInstance(t)
                    as IAssemblyExample).SomeMethod(number));
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}

          