using System;

namespace W3Lab1_Gajjar
{
    public abstract class Animal
    {

        public int id { get; private set; }
        private static int numAnimals;

        public string name { get; set; }

        public Animal(){
            id=numAnimals++;
        }

        public int getNumAnimals(){
            return numAnimals;
        }

        public void setNumAnimals(int n){
            numAnimals=n;
        }
        
        public Animal(string aName){
            name=aName;
        }

        public void Feed(){
            Console.WriteLine(name+" (ID:"+id+") has been feed");
        }

     
        public abstract void MakeANoise();

    }
}