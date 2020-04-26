using System;

namespace W8LAB_GAJJAR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Jack"));
            farm.Animals.Add(new Chicken("Vera"));
            farm.Animals.Add(new Chicken("Sally"));
            farm.Animals.Add(new SuperCow("Kevin"));
            farm.MakeNoises();
            farm.FeedTheAnimals();
            Farm<Cow> dairyFarm = farm.GetCows();
            dairyFarm.FeedTheAnimals();

            foreach (Cow cow in dairyFarm)
            {
                cow.MakeANoise();
                if (cow is SuperCow)
                {
                    (cow as SuperCow).Fly();
                }
            }*/
            Farm<Animal> farm = Farm<Animal>.GetFarm();
            Farm<Cow> cattleFarm = Farm<Cow>.GetFarm();
            Farm<Chicken> chickenFarm = Farm<Chicken>.GetFarm();
            Farm<Animal> farm2 = Farm<Animal>.GetFarm();
            Farm<Chicken> chickenFarm2 = Farm<Chicken>.GetFarm();

            Console.WriteLine("Farm :" + farm.GetHashCode());
            Console.WriteLine("cattleFarm :" + cattleFarm.GetHashCode());
            Console.WriteLine("ChickenFarm :" + chickenFarm.GetHashCode());
            Console.WriteLine("Farm2 :" + farm2.GetHashCode());

            Console.WriteLine("object reference equal for farm and farm 2: {0}", object.ReferenceEquals(farm, farm2));
            Console.WriteLine("object reference equal for ChickenFarm and Chickenfarm 2: {0}", object.ReferenceEquals(chickenFarm, chickenFarm2));

            /*farm.Add(new Cow("Jack"));
            farm.Add(new Chicken("Vera"));
            farm.Add(new Chicken("Sally"));
            farm.Add(new SuperCow("Kelvin"));*/
            AnimalFactory aFactory = new AnimalFactory();
            farm.Add(aFactory.getAnimal("Chicken", "vera"));
            farm.Add(aFactory.getAnimal("cow", "Jack"));
            farm.Add(aFactory.getAnimal("Chicken", "Sally"));
            farm.Add(aFactory.getAnimal("SuperCow", "Kelvin"));

            farm.MakeNoises();
            farm.FeedTheAnimals();

            cattleFarm = farm.GetCows();

            Console.ReadKey();
        }
    }
}
