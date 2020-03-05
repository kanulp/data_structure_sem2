using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_AbstractFactoryPattern
{
    class AnimalWorld

    {
        private Herbivore herbivore;
        private Carnivore carnivore;
        //private ContinentFactory factory;

        // Constructor

        public AnimalWorld(ContinentFactory factory)
        {
            //this.factory = factory;
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivore.Eat(herbivore);
        }
    }
}
