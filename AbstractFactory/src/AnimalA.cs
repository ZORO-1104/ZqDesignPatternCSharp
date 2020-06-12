using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.src
{
    class AnimalA : AbstractAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("我是绵羊，我吃草为生啦。。。");
        }
    }
}
