using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src
{
    class ConcreteMakeFoodB : AbstractMakeFoodTemplate
    {
        protected override void CutFood()
        {
            Console.WriteLine("方式B进行切菜。。。");
        }

        protected override void FryFood()
        {
            Console.WriteLine("方式B进行炒菜。。。");
        }
    }
}
