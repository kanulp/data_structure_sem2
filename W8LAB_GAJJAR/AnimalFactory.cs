using System;

namespace W8LAB_GAJJAR
{
    class AnimalFactory
    {
        internal Animal getAnimal(string v1,string v2)
        {
            Animal a;
            switch (v1)
            {
                case "chicken":
                    a = new Chicken(v2);
                    break;
                case "cow":
                    a = new Cow(v2);
                    break;
                default:
                    a = new Chicken(v2);
                    break;
            }
            return a;
        }
    }
}
