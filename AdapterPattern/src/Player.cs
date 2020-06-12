using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.src
{
    abstract class Player
    {
        protected string _name;
        public Player(string name)
        {
            _name = name;
        }

        //进攻
        public abstract void Attack();

        //防守
        public abstract void Defend();
    }
}
