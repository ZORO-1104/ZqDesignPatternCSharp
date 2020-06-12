using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.src
{
    class ConcreteBuilderA : AbstractBuilder
    {
        public override void BuildPartA()
        {
            _product.SetPartA(MarkInfo() + "BuildPartA");
        }

        public override void BuildPartB()
        {
            _product.SetPartB(MarkInfo() + "BuildPartB");
        }

        public override void BuildPartC()
        {
            _product.SetPartC(MarkInfo() + "BuildPartC");
        }

        private string MarkInfo()
        {
            return "ConcreteBuilderA:";
        }
    }
}
