using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace RObjects
{
    public class Road 
    {
        public string Name { get; set; } = "";
        public double Height { get; set; } = 0.0;
        public Curve Curve { get; set; }
    }
}