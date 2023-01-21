using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class SimpProp
    {
        private int prop;

        public SimpProp()
        {
            prop = 0;
        }
        public int MyProp
        {
            get
            {
                return prop;
            }
            set
            {
                if (value >= 0)
                {
                    prop = value;
                }
            }
        }
    }
}
