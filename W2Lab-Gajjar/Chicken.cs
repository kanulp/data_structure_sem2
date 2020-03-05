using System;

namespace W2Lab_Gajjar
{
    public class Chicken : Animal
    {
        public Chicken(string cName){
            name=cName;
        }

        public void LayEgg(){
            Console.WriteLine(name+" has laid an egg");
        }
    }
}