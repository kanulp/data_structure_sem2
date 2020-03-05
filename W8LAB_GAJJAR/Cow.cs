using System;

namespace W8LAB_GAJJAR
{
    public class Cow : Animal
    {
        public Cow(){
            
        }
        public Cow(string cName){
            name=cName;
        }

        public override void MakeANoise()
        {
            Console.WriteLine(name+" says Moooo.");
        }

        public void Milk(){
            Console.WriteLine(name+" has been milked");
        }
        
    }
}