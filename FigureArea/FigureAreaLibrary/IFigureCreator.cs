using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLibrary
{
    public interface IFigureCreator
    {
        IFigure? CreateFigure(params double[] sides);
    }
}
