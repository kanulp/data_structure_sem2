using System;

namespace W8LAB_GAJJAR
{
    public class Chicken : Animal
    {
        public Chicken(string cName){
            name=cName;
        }

        public void LayEgg(){
            Console.WriteLine(name+" has laid an egg");
        }

        public override void MakeANoise()
        {
            Console.WriteLine(name+" says Cluck.");
        }
    }
}