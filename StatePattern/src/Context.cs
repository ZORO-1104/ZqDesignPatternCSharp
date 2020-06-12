using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.src
{
    class Context
    {
        private AbstractState state;

        public Context(AbstractState state)
        {
            this.state = state;
        }

        public AbstractState State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("当前状态："+state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
