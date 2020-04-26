using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class SpacecraftModel : ICraftModel
    {

        
        private string str;
        private Mesh modelMesh;
        private Texture modelTexture;
        private int maxSpeed;
        private float acceleration, damage;
 

        public SpacecraftModel(string abc, string meshStr, string tex,
            int maxSpeed, float acceleration, float dmg)
        {
            this.str = abc;
            this.modelMesh = new Mesh(meshStr);
            this.modelTexture = new Texture(tex);
            this.maxSpeed = maxSpeed;
            this.acceleration = acceleration;
            this.damage = dmg;
        }


        public float getAcceleration()
        {
            return acceleration;
        }

        public float getDamage()
        {
            return damage;
        }

        public int getMaxSpeed()
        {
            return maxSpeed;
        }

        public string getMesh()
        {
            return modelMesh.Type;
        }

        public string getTexture()
        {
            return modelTexture.Type;
        }
    }
}
