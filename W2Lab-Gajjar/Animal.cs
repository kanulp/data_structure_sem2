using System;

namespace W2Lab_Gajjar
{
    public class Animal
    {
        //private string name;

        public string name { get; set; }

        public Animal(){

        }
        
        public Animal(string aName){
            name=aName;
        }

        public void Feed(){
            Console.WriteLine(name+" has been feed");
        }

    }
}