using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.src
{
    class BuildDirector
    {
        private AbstractBuilder _abstractBuilder;
        public BuildDirector(AbstractBuilder abstractBuilder)
        {
            _abstractBuilder = abstractBuilder;
        }

        //产品构建与组装方法
        public Product ConstructProduct()
        {
            _abstractBuilder.BuildPartA();
            _abstractBuilder.BuildPartB();
            _abstractBuilder.BuildPartC();

            return _abstractBuilder.GetResult();
        }
    }
}
