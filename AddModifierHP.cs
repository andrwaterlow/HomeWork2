using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal sealed class AddModifierHP : Modifier
    {
        private readonly float _hp;

        public AddModifierHP(Player player, float hp) : base(player)
        {
            this._hp = hp;
        }

        public override void Handle()
        {
            Player._hp =+ _hp;
            base.Handle();
        }
    }
}
