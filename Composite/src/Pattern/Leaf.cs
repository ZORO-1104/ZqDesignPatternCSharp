using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.src.Pattern
{
    class Leaf : Component
    {
        public Leaf(string name)
        {
            this.name = name;
        }

        public override void Add(Component c)
        {
        }

        public override Component GetChild(int n)
        {
            return null;
        }

        public override void OperationMethod(int depth)
        {
            ShowNodeInfo(depth);
        }

        public override void Remove(Component c)
        {
        }
    }
}
