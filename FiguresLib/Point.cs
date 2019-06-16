using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresLib
{
    public class Point : Figure
    {

    public Point( double x = 0.0, double y = 0.0)
        {
            x = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
        }
    }
}