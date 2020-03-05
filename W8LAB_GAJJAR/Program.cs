using System;

namespace W8LAB_GAJJAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm<Animal> farm = Farm<Animal>.GetInstance();

            //Farm<Animal> farm = new Farm<Animal>();

            farm.Add(new Cow("Jack"));
            farm.Add(new Chicken("Vera"));
            farm.Add(new Chicken("Sally"));
            farm.Add(new SuperCow("Kevin"));


            farm.MakeNoises();
            farm.FeedTheAnimals();

            //Farm<Cow> dairyFarm = farm.GetCows(); 
            Farm<Cow> dairyFarm = Farm<Cow>.GetInstance();

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
            System.Console.WriteLine("Count : "+dairyFarm.Count);
            System.Console.WriteLine("COntains : "+dairyFarm.Contains(new Cow("Jack1")));


           /*  if (farm == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            } */
        }
    }
}
