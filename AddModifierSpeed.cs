using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal sealed class AddModifierSpeed : Modifier
    {
        private readonly float _speed;

        public AddModifierSpeed(Player player, float speed) : base(player)
        {
            this._speed = speed;
        }

        public override void Handle()
        {
            Player._force =+ _speed;
            base.Handle();
        }
    }
}
