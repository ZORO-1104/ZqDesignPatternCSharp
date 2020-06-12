using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.src.DeepCopy
{
    interface IDeepCopy
    {
        T DeepCopyDispose<T>(T obj);
    }
}
