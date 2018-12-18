using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace RObjects
{
    interface IObject
    {

        string Name { get; set; }
        double Cost { get; set; }
        double CO2eq { get; set;}
        Guid guid { get; set; }
        double Inclination { get; set; }
        Curve Curve { get; set; }

    }
}
