using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    class FarmSimpleFactory
    {
        public string farmName = "B";

        public AbstractAnimal CreateAnimal()
        {
            AbstractAnimal abstractAnimal = null;

            switch (farmName)
            {
                case "A":
                    abstractAnimal = new AnimalA();
                    break;
                case "B":
                    abstractAnimal = new AnimalB();
                    break;
                default:
                    break;
            }

            return abstractAnimal;
        }

        public AbstractPlant CreatePlant()
        {
            AbstractPlant abstractPlant = null;

            switch (farmName)
            {
                case "A":
                    abstractPlant = new PlantA();
                    break;
                case "B":
                    abstractPlant = new PlantB();
                    break;
                default:
                    break;
            }

            return abstractPlant;
        }
    }
}
