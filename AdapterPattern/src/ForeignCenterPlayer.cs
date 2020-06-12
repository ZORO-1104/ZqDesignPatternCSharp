using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.src
{
    class ForeignCenterPlayer
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋{0}发起进攻", _name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋{0}进行防守", _name);
        }
    }
}
