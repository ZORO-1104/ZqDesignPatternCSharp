using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.src
{
    class SubtractFactory : AbstractFactory
    {
        public AbstractOperation CreateProductOperation()
        {
            return new SubtractOperation();
        }
    }
}
