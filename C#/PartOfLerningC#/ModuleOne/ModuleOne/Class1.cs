using AssemblyExample;

namespace ModuleOne
{
    public class ClassOne : IAssemblyExample
    {
        public string SomeMethod(int n)
        {
            return $"ModuleOne: {n}";
        }
    }
}