using System;

namespace W3Lab1_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {

            Farm<Animal> farm = new Farm<Animal>();
            farm.Add(new Cow("Jack"));
            farm.Add(new Chicken("Vera"));
            farm.Add(new Chicken("Sally"));
            farm.Add(new SuperCow("Kevin"));


            farm.MakeNoises();
            farm.FeedTheAnimals();

            Farm<Cow> dairyFarm = farm.GetCows(); 
            dairyFarm.FeedTheAnimals();
            foreach (Cow cow in dairyFarm) {
                cow.MakeANoise();
                cow.Milk();
                if (cow is SuperCow) {
                     (cow as SuperCow).Fly();
                     
                }
            }
            System.Console.WriteLine("Count : "+farm.Count);
            farm.Clear();
            System.Console.WriteLine("Count : "+farm.Count);
            System.Console.WriteLine("COntains : "+farm.Contains(new Cow("Jack1")));
            
            
        }
    }
}
