using System.Reflection;

namespace AppDomainDynamicUnload
{
    internal class Program
    {
        [LoaderOptimization(LoaderOptimization.MultiDomain)]
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CreateDomain("Demo");
            
            Assembly asm = domain.Load(AssemblyName.GetAssemblyName("SampleLibrary.dll"));
            Module module = asm.GetModule("SampleLibrary.dll");
            Type type = module.GetType("SampleLibrary.SampleClass");
            MethodInfo method = type.GetMethod("DoSome");
            method.Invoke(null, null);


            asm.GetModule("SampleLibrary.dll").GetType("SampleLibrary.SampleClass").
                GetMethod("DoSome").Invoke(null, null);
            AppDomain.Unload(domain);
        }
    }
}