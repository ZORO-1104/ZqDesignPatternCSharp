using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.src.Pattern
{
    abstract class Component
    {
        protected string name;

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract Component GetChild(int n);

        public abstract void OperationMethod(int depth);

        protected void ShowNodeInfo(int depth)
        {
            Console.WriteLine(new string('-', depth) + "[" + (depth+1) / 2 + "]" + name);
        }
    }
}
