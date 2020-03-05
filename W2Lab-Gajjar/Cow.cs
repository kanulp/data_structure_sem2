using System;

namespace W2Lab_Gajjar
{
    public class Cow : Animal
    {
        
        public Cow(string cName){
            name=cName;
        }

        public void Milk(){
            Console.WriteLine(name+" has been milked");
        }
    }
}