using System.Reflection;
using static System.Console;

namespace UsingAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();

            //WriteLine($"Assembly name:\n\t{assembly.FullName}\n");
            //WriteLine($"Full path of hte unloaded:\n\t{assembly.Location}\n");
            //WriteLine($"Wheter the assembly  was loaded into" +
            //    $" a context that is intended only for reflection:\n\t" +
            //    $"{assembly.ReflectionOnly}\n");
            //WriteLine($"Originally specified assembly locationn:\n\t" +
            //    $"{assembly.CodeBase}");
            //WriteLine($"Assembly entry point:\n\t{assembly.EntryPoint}");

            //FileStream[] files=assembly.GetFiles(true);
            //WriteLine($"\nNumber of files: {files.Length}");
            //foreach(var f in files)
            //{
            //    WriteLine($"\t{f.Name}");
            //}
            //Module[] modules=assembly.GetModules(true);
            //WriteLine($"Number of modules: {modules.Length}");
            //foreach(Module m in modules)
            //{
            //    WriteLine($"\t{m.Name}");
            //}



            //Assembly a = Assembly.Load("mscorlib");
            //foreach(Type t in a.GetTypes())
            //{
            //    if (!t.IsPrimitive)
            //    {
            //        continue;
            //    }

            //    Write($"Type name: {t.Name}\t");
            //    if(t.BaseType!= null)
            //    {
            //        Write($"\tBase type name: {t.BaseType.Name}");
            //    }
            //    WriteLine();
            //}



        }
    }
}