using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    class PlantA : AbstractPlant
    {
        public override void PourWater()
        {
            Console.WriteLine("我是向日葵，浇自来水就好啦。。。");
        }
    }
}
