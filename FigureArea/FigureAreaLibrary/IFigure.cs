using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
    public interface IFigure
    {
        string Name { get; }
        bool SetParams(params double[] sides);
        double Area();
    }
}
