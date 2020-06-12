using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.src
{
    class ConcreteStateB : AbstractState
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
