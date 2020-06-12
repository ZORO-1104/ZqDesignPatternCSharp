using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    abstract class AbstractFactory
    {
        public abstract AbstractAnimal CreateAnimal();
        public abstract AbstractPlant CreatePlant();
    }
}
