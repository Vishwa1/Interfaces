using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons.Library
{
    /// <summary>
    /// An Interface can have only declarations and NO Implementations!
    /// All members of an interface are PUBLIC by default.
    /// You don't have to specify access modifiers, it would result into compile time error.
    /// </summary>

    public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}
