using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src
{
    class ConcreteMakeFoodA : AbstractMakeFoodTemplate
    {
        protected override void FryFood()
        {
            Console.WriteLine("方式A进行炒菜。。。");
        }

        protected override bool HookIsDrinkWater()
        {
            return false;
        }
    }
}
