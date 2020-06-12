using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite.src.Pattern
{
    class Composite : Component
    {
        private List<Component> child = new List<Component>();

        public Composite(string name)
        {
            this.name = name;
        }

        public override void Add(Component c)
        {
            child.Add(c);
        }

        public override Component GetChild(int n)
        {
            if (n<=child.Count-1 && n>=0)
            {
                return child[n];
            }
            else
            {
                throw new Exception("索引超限");
            }
        }

        public override void OperationMethod(int depth)
        {
            ShowNodeInfo(depth);

            foreach (Component item in child)
            {
                item.OperationMethod(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            if (child.Contains(c))
            {
                child.Remove(c);
            }
        }
    }
}
