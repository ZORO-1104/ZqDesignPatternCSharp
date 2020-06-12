using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AbstractFactory.src
{
    class FarmSimpleFactoryReflectionConfigureFile
    {
        private static readonly string myAssemblyName = "AbstractFactory.src";
        private static string myFarmName;

        public FarmSimpleFactoryReflectionConfigureFile()
        {
            myFarmName = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();

            Console.WriteLine(config["myFarmName"]); // 配置键
            myFarmName = config["myFarmName"];
            //Console.WriteLine(config.GetSection("ConnectionStrings:DevContext").Value); // 分层键
        }

        public AbstractAnimal CreateAnimal()
        {
            string className = myAssemblyName + "." + "Animal" + myFarmName;
            Assembly assem = typeof(AbstractAnimal).Assembly;
            return (AbstractAnimal)assem.CreateInstance(className);


            //return (AbstractAnimal)Assembly.Load(myAssemblyName).CreateInstance(className);
        }

        public AbstractPlant CreatePlant()
        {
            string className = myAssemblyName + "." + "Plant" + myFarmName;
            Assembly assem = typeof(AbstractPlant).Assembly;
            return (AbstractPlant)assem.CreateInstance(className);


            //return (AbstractPlant)Assembly.Load(myAssemblyName).CreateInstance(className);
        }
    }
}
