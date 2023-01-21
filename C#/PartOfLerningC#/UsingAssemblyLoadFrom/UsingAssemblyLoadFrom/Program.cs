using AssemblyExample;

namespace ModulOne
{
    class ClassOne:IAssemblyExample
    {
        public string SomeMethod(int n)
        {
            return $"ModuleOne: {n}";
        }
    }
}