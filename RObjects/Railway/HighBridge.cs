using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace RObjects
{
    public class HighBridge : IObject
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double CO2eq { get; set; }
        public Guid guid { get; set; }
        public Curve Curve { get; set; }
        private double MinHeight { get; }
        public double Inclination { get; set; }

        public HighBridge()
        {
            Name = "";
            MinHeight = 10;

        }
    }
}
