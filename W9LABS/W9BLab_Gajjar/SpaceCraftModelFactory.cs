using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class SpaceCraftModelFactory
    {

        static object Lock = new object();

        private Dictionary<string, ICraftModel> craft;

        private static SpaceCraftModelFactory factory;
        private SpaceCraftModelFactory()
        {
            craft = new Dictionary<string, ICraftModel>();
        }

        public static SpaceCraftModelFactory getInstance()
        {
            lock (Lock)
            {
                if (factory == null)
                {
                    factory = new SpaceCraftModelFactory();
                }
                return factory;
            }
        }

        public ICraftModel getSpacecraftModel(string type)
        {
            lock (Lock)
            {
                if (!craft.ContainsKey(type))
                {
                 
                    if (type.Equals("NukeMayhem"))
                    {
                        craft.Add(type, new SpacecraftModel(type,
                                 "Iron", "Iron Plate", 3000, 20f, 35000f));
                    }

                    else if (type.Equals("CoreDriller"))
                    {
                        craft.Add(type, new SpacecraftModel(type,
                                "Steel", "Steel Plate", 4500, 15f, 22000f));
                    }

                    else if (type.Equals("SwiftMaple"))
                    {
                        craft.Add(type, new SpacecraftModel(type,
                                  "Gold", "Gold Plate", 9000, 50f, 90000f));
                    }



                }

                return craft[type];
            }
        }


    }
}
