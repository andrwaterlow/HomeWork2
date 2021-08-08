using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    internal sealed class AddModifierAttack : Modifier
    { 
        private readonly float _attack;

        public AddModifierAttack(Player player, float attack) : base(player)
        {
            this._attack = attack;
        }

        public override void Handle()
        {
            Player._attack =+ _attack;
            base.Handle();
        }
    }
}
