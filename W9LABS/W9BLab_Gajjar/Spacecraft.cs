using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class Spacecraft
    {
        private static int counter = 1;
        private ICraftModel craftModel;
        private Coordinate coordinate;
        private int craftId;


        public Spacecraft(string str, Coordinate coordinates)
        {
            craftId = counter++;
            craftModel = SpaceCraftModelFactory.getInstance().getSpacecraftModel(str);
            coordinate = coordinates;
        }


        public void run()
        {
            Console.WriteLine(" Id:"+ craftId);
            Console.WriteLine("Coordinates are as : " + coordinate.X + ", " + coordinate.Y + ", " + coordinate.Z);
            Console.WriteLine( "Texture"+craftModel.getTexture());
            Console.WriteLine( "Mesh"+craftModel.getMesh());
            Console.WriteLine("Maxspeed" +craftModel.getMaxSpeed());
            Console.WriteLine("Acc"+craftModel.getAcceleration());
            Console.WriteLine("Damage"+craftModel.getDamage());
        }
    }
}
