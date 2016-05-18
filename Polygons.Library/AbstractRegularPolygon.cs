using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    /// <summary>
    /// 1. Abstract class :  is a class which has 2 or more abstract members.
    /// 2. Abstract Member : It's a member which is declared but not implemented.
    /// 3. if you have even a single abstract member, class should be abstract too!
    /// 4. We can't create an instance of an abstract class because it contains members which are not implemented.
    /// </summary>

    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int side, int length)
        {
            NumberOfSides = side;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return SideLength * SideLength;
        }

        public abstract double GetArea();
    }
}
