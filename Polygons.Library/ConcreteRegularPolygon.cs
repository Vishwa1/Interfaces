using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }

        public ConcreteRegularPolygon(int length, int side)
        {
            NumberOfSides = side;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
