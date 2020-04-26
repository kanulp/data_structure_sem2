using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class Texture
    {
        private readonly string type;

        public string Type
        {
            get { return type; }
        }

        public Texture(string type)
        {
            this.type = type;
        }
    }
}
