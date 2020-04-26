using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    interface ICraftModel
    {
        //No method Body as its an Interface
        string getMesh();


        string getTexture();


        int getMaxSpeed();


        float getAcceleration();


        float getDamage();

    }
}
