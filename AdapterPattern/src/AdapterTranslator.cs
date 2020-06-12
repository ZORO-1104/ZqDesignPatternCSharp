using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.src
{
    class AdapterTranslator : Player
    {
        private ForeignCenterPlayer _foreignCenterPlayer = new ForeignCenterPlayer();
        public AdapterTranslator(string name):base(name)
        {
            _foreignCenterPlayer.Name = _name;
        }
        public override void Attack()
        {
            _foreignCenterPlayer.进攻();
        }

        public override void Defend()
        {
            _foreignCenterPlayer.防守();
        }
    }
}
