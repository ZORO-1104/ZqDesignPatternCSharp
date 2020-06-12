using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.src
{
    abstract class AbstractState
    {
        public abstract void Handle(Context context);
    }
}
