﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.src
{
    class ForwardPlayer : Player
    {
        public ForwardPlayer(string name):base(name)
        {

        }

        public override void Attack()
        {
            Console.WriteLine("前卫{0}发起进攻", _name);
        }

        public override void Defend()
        {
            Console.WriteLine("前卫{0}进行防守", _name);
        }
    }
}
