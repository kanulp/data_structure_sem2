using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class Coordinate
    {

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Coordinate(float xaxis, float yaxis, float zaxis)
        {
            this.X = xaxis;
            this.Y = yaxis;
            this.Z = zaxis;
        }

    }
}
