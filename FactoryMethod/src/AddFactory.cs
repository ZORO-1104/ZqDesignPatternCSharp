using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.src
{
    class AddFactory : AbstractFactory
    {
        public AbstractOperation CreateProductOperation()
        {
            return new AddOperation();
        }
    }
}
