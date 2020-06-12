using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    //农场工厂B（老虎和花生）
    class FarmFactoryB : AbstractFactory
    {
        public override AbstractAnimal CreateAnimal()
        {
            return new AnimalB();
        }

        public override AbstractPlant CreatePlant()
        {
            return new PlantB();
        }
    }
}
