using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    class PlantB : AbstractPlant
    {
        public override void PourWater()
        {
            Console.WriteLine("我是花生，不止要浇水，还要施肥，不然我不长的。。。");
        }
    }
}
