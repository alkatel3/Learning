using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CombinationFigures 
    {
        Figure[] Figures;
        public CombinationFigures(params Figure[] figuses)
        {
            Figures = figuses;
        }

        public double Square()
        {
            double result = 0;
            foreach (var item in Figures)
            {
                result += item.Square();
            }
            return result;
        }
    }
}
