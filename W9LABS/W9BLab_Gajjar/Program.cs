using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9BLab_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arList = new ArrayList();

            arList.Add(new Spacecraft("NukeMayhem", new Coordinate(6,8,10)));
           
            arList.Add(new Spacecraft("SwiftMaple", new Coordinate(44, 22, 199)));
            arList.Add(new Spacecraft("NukeMayhem", new Coordinate(5,9,30)));

            arList.Add(new Spacecraft("SwiftMaple", new Coordinate(40,60,90)));
            arList.Add(new Spacecraft("SwiftMaple", new Coordinate(71, 92, 40)));


            arList.Add(new Spacecraft("NukeMayhem", new Coordinate(49, 23, 47)));
            arList.Add(new Spacecraft("CoreDriller", new Coordinate(14, 52, 113)));
            arList.Add(new Spacecraft("SwiftMaple", new Coordinate(19, 300, 70)));

            arList.Add(new Spacecraft("CoreDriller", new Coordinate(2, 5, 8)));
            arList.Add(new Spacecraft("CoreDriller", new Coordinate(20, 40, 60)));

            foreach (Spacecraft ship in arList)
            {
                ship.run();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
