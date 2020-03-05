using System;

namespace W8LAB_GAJJAR
{
    public class SuperCow : Cow
    {
        public SuperCow(string cName){
            name=cName;
        }

        public void Fly(){
            Console.WriteLine(name+" is flying.. and doing the Superman things.");
        }

        public override void MakeANoise(){
            Console.WriteLine(name+"SuperCow, Up up and away to save the cows!");
        }
    }
}