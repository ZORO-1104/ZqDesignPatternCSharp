using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.src
{
    //抽象工厂类
    interface AbstractFactory
    {
        //定义接口：生成抽象产品类的方法
        AbstractOperation CreateProductOperation();
    }
}
