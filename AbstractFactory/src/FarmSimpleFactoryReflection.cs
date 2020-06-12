using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AbstractFactory.src
{
    class FarmSimpleFactoryReflection
    {
        private static readonly string myAssemblyName = "AbstractFactory.src";
        private static readonly string myFarmName = "A";

        public AbstractAnimal CreateAnimal()
        {
            Assembly assem = typeof(AbstractAnimal).Assembly;
            string className = myAssemblyName + "." + "Animal" + myFarmName; 
            //return (AbstractAnimal)Assembly.Load(myAssemblyName).CreateInstance(className);
            return (AbstractAnimal)assem.CreateInstance(className);
        }

        public AbstractPlant CreatePlant()
        {
            Assembly assem = typeof(AbstractPlant).Assembly;
            string className = myAssemblyName + "." + "Plant" + myFarmName;
            //return (AbstractPlant)Assembly.Load(myAssemblyName).CreateInstance(className);
            return (AbstractPlant)assem.CreateInstance(className);
        }
    }
}
