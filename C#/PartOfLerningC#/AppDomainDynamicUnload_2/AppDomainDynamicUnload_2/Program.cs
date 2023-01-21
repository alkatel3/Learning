using System;
using System.Reflection;

namespace AppDomainDynamicUnload_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain Domain = AppDomain.CreateDomain("Demo");
            Assembly asm = Domain.Load(AssemblyName.GetAssemblyName("SampleLibrary.dll"));
            Module module = asm.GetModule("SampleLibrary.dll");
            Type type = module.GetType("SampleLibrary.SampleClass");
            MethodInfo method = type.GetMethod("DoSome");
            method.Invoke(null, null);


            asm.GetModule("SampleLibrary.dll").GetType("SampleLibrary.SampleClass").
                GetMethod("DoSome").Invoke(null, null);
            AppDomain.Unload(Domain);
        }
    }
}
