using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.src
{
    abstract class AbstractBuilder
    {
        protected Product _product = new Product();
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();

        public Product GetResult()
        {
            return _product;
        }
    }
}
