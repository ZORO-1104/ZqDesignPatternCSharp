using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    //农场工厂A（绵羊和向日葵）
    class FarmFactoryA : AbstractFactory
    {
        public override AbstractAnimal CreateAnimal()
        {
            return new AnimalA();
        }

        public override AbstractPlant CreatePlant()
        {
            return new PlantA();
        }
    }
}
