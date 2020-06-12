using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    class AnimalB : AbstractAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("我是老虎，我要吃肉，不然我把你吃了。。。");
        }
    }
}
