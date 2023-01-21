using AssemblyExample;

namespace ModuleTwo
{
    public class ClassTwo : IAssemblyExample
    {
        public string SomeMethod(int n)
        {
            return $"ModuleTwo increment {++n}";
        }
    }
}