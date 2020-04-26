using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class Mesh
    {
        private readonly string type;

        public string Type {
            get {

                return type;

            } }

        public Mesh(string str)
        {
            this.type = str;
        }

    }
}
