using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.src
{
    abstract class AbstractMakeFoodTemplate
    {

        //做饭并吃饭
        //算法骨架
        public void MakeFood()
        {
            Console.WriteLine("------------------");

            //洗菜
            WashFood();

            //切菜
            //（钩子方法virtual）
            //（子类可实现，也可不实现）
            //子类有实现，则按照子类执行
            //子类没有实现，则按照父类执行
            CutFood();

            //开火
            OpenFire();

            //炒菜
            FryFood();

            //装盘
            MakeInPlate();

            //倒上一杯水
            if (HookIsDrinkWater())
            {
                PourWater();
            }            

            //开工
            BeginEat();

            Console.WriteLine();
            Console.WriteLine();

        }

        //是否需要喝水的（钩子方法）
        protected virtual bool HookIsDrinkWater()
        {
            return true;
        }

        private void PourWater()
        {
            Console.WriteLine("倒上一杯水。。");
        }

        //具体实现延时到子类去实现
        //不想改方法暴露到外面，（），故采用protected
        protected abstract void FryFood();

        protected virtual void CutFood()
        {
            Console.WriteLine("父类：切菜。。。");
        }

        private void MakeInPlate()
        {
            Console.WriteLine("装盘完成。。。");
        }

        private void OpenFire()
        {
            Console.WriteLine("开火准备炒菜。。。");
        }


        private void WashFood()
        {
            Console.WriteLine("洗菜。。。");
        }

        private void BeginEat()
        {
            Console.WriteLine("开吃。。。");
        }
    }
}
