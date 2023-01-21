using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_classes
{
    public partial class Class2
    {
        public partial void Metod4();
        public void Metod5()
        {
            Console.WriteLine("start metod 5 in class2.2");
            Metod4();
            Console.WriteLine("finish metod 5 int class2.2");
        }
    }
}
