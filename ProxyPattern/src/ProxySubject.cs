using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.src
{
    class ProxySubject : ISubject
    {
        private ISubject _realSubject;

        public ProxySubject(ISubject subject)
        {
            _realSubject = subject;
        }

        public void Execute()
        {
            _realSubject?.Execute();
        }
    }
}
